using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.Task22
{
    public class Importer
    {
        public CellLifeState[,] ImportCellMatrix(string[] text,CellLifeState[,] lifeState)
        {

            for (int i = 0; i < text.Length; i++)
            {
                for (int a = 0; a < text[i].Length; a++)
                {
                    if (text[i][a] == '#')
                    {
                        lifeState[i, a] = CellLifeState.Alive;
                    }
                    else
                    {
                        lifeState[i, a] = CellLifeState.Dead;
                    }

                }

            }

            return lifeState;

        }
    }
    public enum CellLifeState
    {
        Alive,
        Dead,
    }
}
