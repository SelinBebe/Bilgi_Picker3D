using System.Collections.Generic;
using System;

namespace Data.ValueObjects
{
    [Serializable]
    public class LevelData
    {
        public List<PoolData> PoolList = new List<PoolData>();

        public LevelData(List<PoolData> datas)
        {
            PoolData = datas;
        }
    }

    [Serializable]
    public struct PoolData
    {
        public byte RequiredObjectCount;
    }
}