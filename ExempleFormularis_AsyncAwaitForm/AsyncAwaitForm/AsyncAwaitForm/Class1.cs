using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace AsyncAwaitForm
{
    public class Cervesa
    {
        private readonly string _nom;
        public Cervesa(string nom)
        {
            _nom = nom;
        }

        public string Nom { get { return _nom; } }
    }


    public class Cambrer
    {
        public Task<Cervesa> ServirCervesa(string nom)
        {
            return new Task<Cervesa>(() =>
            {
                Thread.Sleep(5000);
                return new Cervesa(nom);
            });
        }

       
    }
}
