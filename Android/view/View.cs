using android.content;
using android.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace java.view
{
    public  class View
    {
        private static readonly bool DBG = false;

    /** @hide */
    public static bool DEBUG_DRAW = false;

        /**
         * The logging tag used by this class with android.util.Log.
         */
        protected static readonly String VIEW_LOG_TAG = "View";

    /**
     * The logging tag used by this class when logging verbose, autofill-related messages.
     */
    // NOTE: We cannot use android.view.autofill.Helper.sVerbose because that variable is not
    // set if a session is not started.
    private static readonly String AUTOFILL_LOG_TAG = "View.Autofill";

    /**
     * The logging tag used by this class when logging content capture-related messages.
     */
    private static readonly String CONTENT_CAPTURE_LOG_TAG = "View.ContentCapture";

    private static readonly bool DEBUG_CONTENT_CAPTURE = false;

    /**
     * When set to true, this view will save its attribute data.
     *
     * @hide
     */
    public static bool sDebugViewAttributes = false;

        /**
         * When set to this application package view will save its attribute data.
         *
         * @hide
         */
        public static String sDebugViewAttributesApplicationPackage;

        /**
         * Used to mark a View that has no ID.
         */
        public static readonly int NO_ID = -1;

        /**
         * Last ID that is given to Views that are no part of activities.
         *
         * {@hide}
         */
        public static readonly int LAST_APP_AUTOFILL_ID = Integer.MAX_VALUE / 2;

        /**
         * Attribute to find the autofilled highlight
         *
         * @see #getAutofilledDrawable()
         */
        private static readonly int[] AUTOFILL_HIGHLIGHT_ATTR =
                new int[] { android.R.attr.autofilledHighlight };

        /**
         * Signals that compatibility booleans have been initialized according to
         * target SDK versions.
         */
        private static bool sCompatibilityDone = false;

        /**
         * Use the old (broken) way of building MeasureSpecs.
         */
        private static bool sUseBrokenMakeMeasureSpec = false;

        /**
         * Always return a size of 0 for MeasureSpec values with a mode of UNSPECIFIED
         */
        static bool sUseZeroUnspecifiedMeasureSpec = false;

        /**
         * Ignore any optimizations using the measure cache.
         */
        private static bool sIgnoreMeasureCache = false;

        /**
         * Ignore an optimization that skips unnecessary EXACTLY layout passes.
         */
        private static bool sAlwaysRemeasureExactly = false;

        /**
         * Allow setForeground/setBackground to be called (and ignored) on a textureview,
         * without throwing
         */
        static bool sTextureViewIgnoresDrawableSetters = false;

        /**
         * Prior to N, some ViewGroups would not convert LayoutParams properly even though both extend
         * MarginLayoutParams. For instance, converting LinearLayout.LayoutParams to
         * RelativeLayout.LayoutParams would lose margin information. This is fixed on N but target API
         * check is implemented for backwards compatibility.
         *
         * {@hide}
         */
        protected static bool sPreserveMarginParamsInLayoutParamConversion;

        /**
         * Prior to N, when drag enters into child of a view that has already received an
         * ACTION_DRAG_ENTERED event, the parent doesn't get a ACTION_DRAG_EXITED event.
         * ACTION_DRAG_LOCATION and ACTION_DROP were delivered to the parent of a view that returned
         * false from its event handler for these events.
         * Starting from N, the parent will get ACTION_DRAG_EXITED event before the child gets its
         * ACTION_DRAG_ENTERED. ACTION_DRAG_LOCATION and ACTION_DROP are never propagated to the parent.
         * sCascadedDragDrop is true for pre-N apps for backwards compatibility implementation.
         */
        static bool sCascadedDragDrop;

        /**
         * Prior to O, auto-focusable didn't exist and widgets such as ListView use hasFocusable
         * to determine things like whether or not to permit item click events. We can't break
         * apps that do this just because more things (clickable things) are now auto-focusable
         * and they would get different results, so give old behavior to old apps.
         */
        static bool sHasFocusableExcludeAutoFocusable;

        /**
         * Prior to O, auto-focusable didn't exist and views marked as clickable weren't implicitly
         * made focusable by default. As a result, apps could (incorrectly) change the clickable
         * setting of views off the UI thread. Now that clickable can effect the focusable state,
         * changing the clickable attribute off the UI thread will cause an exception (since changing
         * the focusable state checks). In order to prevent apps from crashing, we will handle this
         * specific case and just not notify parents on new focusables resulting from marking views
         * clickable from outside the UI thread.
         */
        private static bool sAutoFocusableOffUIThreadWontNotifyParents;

        /**
         * Prior to P things like setScaleX() allowed passing float values that were bogus such as
         * Float.NaN. If the app is targetting P or later then passing these values will result in an
         * exception being thrown. If the app is targetting an earlier SDK version, then we will
         * silently clamp these values to avoid crashes elsewhere when the rendering code hits
         * these bogus values.
         */
        private static bool sThrowOnInvalidFloatProperties;

        /**
         * Prior to P, {@code #startDragAndDrop} accepts a builder which produces an empty drag shadow.
         * Currently zero size SurfaceControl cannot be created thus we create a dummy 1x1 surface
         * instead.
         */
        private static bool sAcceptZeroSizeDragShadow;

        /**
         * Prior to Q, {@link #dispatchApplyWindowInsets} had some issues:
         * <ul>
         *     <li>The modified insets changed by {@link #onApplyWindowInsets} were passed to the
         *     entire view hierarchy in prefix order, including siblings as well as siblings of parents
         *     further down the hierarchy. This violates the basic concepts of the view hierarchy, and
         *     thus, the hierarchical dispatching mechanism was hard to use for apps.</li>
         *
         *     <li>Dispatch was stopped after the insets were fully consumed. This is somewhat confusing
         *     for developers, but more importantly, by adding more granular information to
         *     {@link WindowInsets} it becomes really cumbersome to define what consumed actually means
         *     </li>
         * </ul>
         *
         * In order to make window inset dispatching work properly, we dispatch window insets
         * in the view hierarchy in a proper hierarchical manner and don't stop dispatching if the
         * insets are consumed if this flag is set to {@code false}.
         */
        static bool sBrokenInsetsDispatch;

        /**
         * Prior to Q, calling
         * {@link com.android.internal.policy.DecorView#setBackgroundDrawable(Drawable)}
         * did not call update the window format so the opacity of the background was not correctly
         * applied to the window. Some applications rely on this misbehavior to work properly.
         * <p>
         * From Q, {@link com.android.internal.policy.DecorView#setBackgroundDrawable(Drawable)} is
         * the same as {@link com.android.internal.policy.DecorView#setWindowBackground(Drawable)}
         * which updates the window format.
         * @hide
         */
        protected static bool sBrokenWindowBackground;


    public interface Focusable { }

        /**
         * This view does not want keystrokes.
         * <p>
         * Use with {@link #setFocusable(int)} and <a href="#attr_android:focusable">{@code
         * android:focusable}.
         */
        public static readonly int NOT_FOCUSABLE = 0x00000000;

        /**
         * This view wants keystrokes.
         * <p>
         * Use with {@link #setFocusable(int)} and <a href="#attr_android:focusable">{@code
         * android:focusable}.
         */
        public static readonly int FOCUSABLE = 0x00000001;

        /**
         * This view determines focusability automatically. This is the default.
         * <p>
         * Use with {@link #setFocusable(int)} and <a href="#attr_android:focusable">{@code
         * android:focusable}.
         */
        public static readonly int FOCUSABLE_AUTO = 0x00000010;

        /**
         * Mask for use with setFlags indicating bits used for focus.
         */
        private static readonly int FOCUSABLE_MASK = 0x00000011;

        /**
         * This view will adjust its padding to fit sytem windows (e.g. status bar)
         */
        private static readonly int FITS_SYSTEM_WINDOWS = 0x00000002;

        /** @hide */
        @IntDef({ VISIBLE, INVISIBLE, GONE})
    @Retention(RetentionPolicy.SOURCE)
    public @interface Visibility { }

        /**
         * This view is visible.
         * Use with {@link #setVisibility} and <a href="#attr_android:visibility">{@code
         * android:visibility}.
         */
        public static readonly int VISIBLE = 0x00000000;

        /**
         * This view is invisible, but it still takes up space for layout purposes.
         * Use with {@link #setVisibility} and <a href="#attr_android:visibility">{@code
         * android:visibility}.
         */
        public static readonly int INVISIBLE = 0x00000004;

        /**
         * This view is invisible, and it doesn't take any space for layout
         * purposes. Use with {@link #setVisibility} and <a href="#attr_android:visibility">{@code
         * android:visibility}.
         */
        public static readonly int GONE = 0x00000008;

        /**
         * Mask for use with setFlags indicating bits used for visibility.
         * {@hide}
         */
        static readonly int VISIBILITY_MASK = 0x0000000C;
        private Panel panel;
        public View(Panel panel)
        {
            this.panel = panel;
        }
        public static Visibility GONE
        {
            get
            {
                return Visibility.Collapsed;
            }
        }

        public ViewParent getParent()
        {
            return new View(panel.Parent);
        }
        public  int getVisibility()
        {
            return (int)panel.Visibility;
        }
        public  Context getContext()
        {
            return null;
        }
    }
}
