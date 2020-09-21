﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace android.util
{
    public class TypedValue
    {
        public static readonly int TYPE_NULL = 0x00;

        /** The <var>data</var> field holds a resource identifier. */
        public static readonly int TYPE_REFERENCE = 0x01;
        /** The <var>data</var> field holds an attribute resource
         *  identifier (referencing an attribute in the current theme
         *  style, not a resource entry). */
        public static readonly int TYPE_ATTRIBUTE = 0x02;
        /** The <var>string</var> field holds string data.  In addition, if
         *  <var>data</var> is non-zero then it is the string block
         *  index of the string and <var>assetCookie</var> is the set of
         *  assets the string came from. */
        public static readonly int TYPE_STRING = 0x03;
        /** The <var>data</var> field holds an IEEE 754 floating point number. */
        public static readonly int TYPE_FLOAT = 0x04;
        /** The <var>data</var> field holds a complex number encoding a
         *  dimension value. */
        public static readonly int TYPE_DIMENSION = 0x05;
        /** The <var>data</var> field holds a complex number encoding a fraction
         *  of a container. */
        public static readonly int TYPE_FRACTION = 0x06;

        /** Identifies the start of plain integer values.  Any type value
         *  from this to {@link #TYPE_LAST_INT} means the
         *  <var>data</var> field holds a generic integer value. */
        public static readonly int TYPE_FIRST_INT = 0x10;

        /** The <var>data</var> field holds a number that was
         *  originally specified in decimal. */
        public static readonly int TYPE_INT_DEC = 0x10;
        /** The <var>data</var> field holds a number that was
         *  originally specified in hexadecimal (0xn). */
        public static readonly int TYPE_INT_HEX = 0x11;
        /** The <var>data</var> field holds 0 or 1 that was originally
         *  specified as "false" or "true". */
        public static readonly int TYPE_INT_BOOLEAN = 0x12;

        public static int applyDimension(int cOMPLEX_UNIT_DIP, float dp, DisplayMetrics displayMetrics)
        {
            return (int)dp;
        }

        /** Identifies the start of integer values that were specified as
         *  color constants (starting with '#'). */
        public static readonly int TYPE_FIRST_COLOR_INT = 0x1c;

        /** The <var>data</var> field holds a color that was originally
         *  specified as #aarrggbb. */
        public static readonly int TYPE_INT_COLOR_ARGB8 = 0x1c;
        /** The <var>data</var> field holds a color that was originally
         *  specified as #rrggbb. */
        public static readonly int TYPE_INT_COLOR_RGB8 = 0x1d;
        /** The <var>data</var> field holds a color that was originally
         *  specified as #argb. */
        public static readonly int TYPE_INT_COLOR_ARGB4 = 0x1e;
        /** The <var>data</var> field holds a color that was originally
         *  specified as #rgb. */
        public static readonly int TYPE_INT_COLOR_RGB4 = 0x1f;

        /** Identifies the end of integer values that were specified as color
         *  constants. */
        public static readonly int TYPE_LAST_COLOR_INT = 0x1f;

        /** Identifies the end of plain integer values. */
        public static readonly int TYPE_LAST_INT = 0x1f;

        /* ------------------------------------------------------------ */

        /** Complex data: bit location of unit information. */
        public static readonly int COMPLEX_UNIT_SHIFT = 0;
        /** Complex data: mask to extract unit information (after shifting by
         *  {@link #COMPLEX_UNIT_SHIFT}). This gives us 16 possible types, as
         *  defined below. */
        public static readonly int COMPLEX_UNIT_MASK = 0xf;

        /** {@link #TYPE_DIMENSION} complex unit: Value is raw pixels. */
        public static readonly int COMPLEX_UNIT_PX = 0;
        /** {@link #TYPE_DIMENSION} complex unit: Value is Device Independent
         *  Pixels. */
        public static readonly int COMPLEX_UNIT_DIP = 1;
        /** {@link #TYPE_DIMENSION} complex unit: Value is a scaled pixel. */
        public static readonly int COMPLEX_UNIT_SP = 2;
        /** {@link #TYPE_DIMENSION} complex unit: Value is in points. */
        public static readonly int COMPLEX_UNIT_PT = 3;
        /** {@link #TYPE_DIMENSION} complex unit: Value is in inches. */
        public static readonly int COMPLEX_UNIT_IN = 4;
        /** {@link #TYPE_DIMENSION} complex unit: Value is in millimeters. */
        public static readonly int COMPLEX_UNIT_MM = 5;

        /** {@link #TYPE_FRACTION} complex unit: A basic fraction of the overall
         *  size. */
        public static readonly int COMPLEX_UNIT_FRACTION = 0;
        /** {@link #TYPE_FRACTION} complex unit: A fraction of the parent size. */
        public static readonly int COMPLEX_UNIT_FRACTION_PARENT = 1;

        /** Complex data: where the radix information is, telling where the decimal
         *  place appears in the mantissa. */
        public static readonly int COMPLEX_RADIX_SHIFT = 4;
        /** Complex data: mask to extract radix information (after shifting by
         * {@link #COMPLEX_RADIX_SHIFT}). This give us 4 possible fixed point 
         * representations as defined below. */
        public static readonly int COMPLEX_RADIX_MASK = 0x3;

        /** Complex data: the mantissa is an integral number -- i.e., 0xnnnnnn.0 */
        public static readonly int COMPLEX_RADIX_23p0 = 0;
        /** Complex data: the mantissa magnitude is 16 bits -- i.e, 0xnnnn.nn */
        public static readonly int COMPLEX_RADIX_16p7 = 1;
        /** Complex data: the mantissa magnitude is 8 bits -- i.e, 0xnn.nnnn */
        public static readonly int COMPLEX_RADIX_8p15 = 2;
        /** Complex data: the mantissa magnitude is 0 bits -- i.e, 0x0.nnnnnn */
        public static readonly int COMPLEX_RADIX_0p23 = 3;

        /** Complex data: bit location of mantissa information. */
        public static readonly int COMPLEX_MANTISSA_SHIFT = 8;
        /** Complex data: mask to extract mantissa information (after shifting by
         *  {@link #COMPLEX_MANTISSA_SHIFT}). This gives us 23 bits of precision;
         *  the top bit is the sign. */
        public static readonly int COMPLEX_MANTISSA_MASK = 0xffffff;

        /* ------------------------------------------------------------ */

        /**
         * {@link #TYPE_NULL} data indicating the value was not specified.
         */
        public static readonly int DATA_NULL_UNDEFINED = 0;
        /**
         * {@link #TYPE_NULL} data indicating the value was explicitly set to null.
         */
        public static readonly int DATA_NULL_EMPTY = 1;

        /* ------------------------------------------------------------ */

        /**
         * If {@link #density} is equal to this value, then the density should be
         * treated as the system's default density value: {@link DisplayMetrics#DENSITY_DEFAULT}.
         */
        public static readonly int DENSITY_DEFAULT = 0;

        /**
         * If {@link #density} is equal to this value, then there is no density
         * associated with the resource and it should not be scaled.
         */
        public static readonly int DENSITY_NONE = 0xffff;
    }
}
