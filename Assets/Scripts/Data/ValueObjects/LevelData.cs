using System.Collections.Generic;
using System;

namespace Data.ValueObjects
{
    [Serializable]
    public class LevelData
    {
        public List<PoolData> PoolList = new List<PoolData>();
    }

    [Serializable]
    public struct PoolData
    {
        public sbyte RequiredObjectCount;
    }
}