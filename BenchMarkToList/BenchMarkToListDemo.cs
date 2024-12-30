using BenchmarkDotNet.Attributes;
using System.Text;

namespace BenchMarkToList
{
    [MemoryDiagnoser]
    public class BenchMarkToListDemo
    {
        [Params(10, 1000)] 
        
        public int conteo { get; set; }

        private int[] arreglo;

        [GlobalSetup]
        public void Setup()
        {
            arreglo = Enumerable.Range(1, conteo).ToArray();
        }

        [Benchmark(Baseline = true)]
        public void ToListPuntoLongitudMayorACero()
        {
            if (arreglo.Where(a => a == 4).ToList().Count > 0)
            {
            }
        }
        
        [Benchmark]
        public void WhereCountMayorACero()
        {
            if (arreglo.Where(a => a == 4).Count() > 0)
            {
            }
        }
        
        [Benchmark]
        public void LinqWhereCountMayorACero()
        {
            if (arreglo.Where(a => a == 4).Any())
            {
            }
        }
        
        [Benchmark]
        public void LinqAny()
        {
            if (arreglo.Any(a => a == 4))
            {
            }
        }
    }   
}