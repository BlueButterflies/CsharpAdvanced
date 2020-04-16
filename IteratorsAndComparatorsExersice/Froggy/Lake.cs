using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Froggy
{
    public class Lake : IEnumerable<int>
    {
        private List<int> Position;
        private int Index;

        public Lake(List<int> position)
        {
            this.Position = position;
        }
        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < this.Position.Count; i++)
            {
                if (i % 2 == 0)
                {
                    yield return this.Position[i];

                }
            }

            for (int i = this.Position.Count; i >= 0; i--)
            {
                if (i % 2 != 0)
                {
                    yield return this.Position[i];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
