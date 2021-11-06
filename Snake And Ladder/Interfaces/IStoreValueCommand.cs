using Snake_And_Ladder.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Snake_And_Ladder.Interfaces
{
    public interface IStoreValueCommand
    {
        void StoreData(StoreValuesCommand store);
    }
}
