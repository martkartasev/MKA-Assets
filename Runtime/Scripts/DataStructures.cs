using System;

namespace Scripts
{
    [Serializable]
    public struct RangeFloat
    {
        public float min;
        public float max;
        
        public RangeFloat(float min, float max)
        {
            this.min = min;
            this.max = max;
        }
    }
}