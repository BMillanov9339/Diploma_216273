using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diploma_216273.Modules
{
    public class MeasurementBuffer
    {
        private readonly int maxSize;
        private readonly Queue<double> buffer;

        public MeasurementBuffer(int maxSize = 60)
        {
            this.maxSize = maxSize;
            buffer = new Queue<double>(maxSize);
        }

        public void Add(double value)
        {
            if (buffer.Count >= maxSize)
                buffer.Dequeue();

            buffer.Enqueue(value);
        }

        public double[] GetAll() => buffer.ToArray();

        public double[] GetLatest(int count) =>
            buffer.Skip(Math.Max(0, buffer.Count - count)).ToArray();
    }

}
