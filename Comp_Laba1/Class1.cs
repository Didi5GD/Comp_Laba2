using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp_Laba1
{
    public static class TextSizeManager
    {
        public static event EventHandler TextSizeChanged;

        private static float currentSize = 12f;

        public static float CurrentSize
        {
            get => currentSize;
            set
            {
                if (currentSize != value && value >= 6 && value <= 72)
                {
                    currentSize = value;
                    TextSizeChanged?.Invoke(null, EventArgs.Empty);
                }
            }
        }

        public static void IncreaseSize()
        {
            CurrentSize += 1;
        }

        public static void DecreaseSize()
        {
            CurrentSize -= 1;
        }

        public static void ResetSize()
        {
            CurrentSize = 12f;
        }
    }
}
