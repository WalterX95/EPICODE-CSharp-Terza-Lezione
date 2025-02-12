using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class ContoCorrente
    {
        private int _idConto;
        private string _nomeConto = string.Empty;
        private string _cognomeConto = string.Empty;
        private int _saldoCorrente;
        private string _bankName = string.Empty;
        private bool _isOpenCount = false;

        public int IdConto { get { return _idConto; } set { _idConto = value; } }
        public string NameConto { get { return _nomeConto; } set { _nomeConto = value; _cognomeConto = value; } }
        public string CognomeConto { get { return _cognomeConto; } set { _cognomeConto = value; } }

        public int SaldoCorrente { get { return _saldoCorrente; } set { _saldoCorrente = value; } }

        public string BankName { get { return _bankName; } set { _bankName = value; } }

        public bool OpenCount { get { return _isOpenCount;  } set { _isOpenCount = value; } }
        public ContoCorrente(int nConto, string nameConto, string cognomeConto ,string bankName ,int saldo) {
            _idConto = nConto;
            _nomeConto = nameConto;
            _cognomeConto = cognomeConto;
            _bankName = bankName;
            _saldoCorrente = saldo;
        }
        public int ApriConto(int idConto)
        {

            if (OpenCount == true)
            {
                Console.WriteLine("Il conto è già aperto per questo cliente");
                return 0;
            }

            if (_saldoCorrente < 1000)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Impossibile Aprire Il conto Corrente hai meno di 1.000 euro ");
                
                
            }
            else if (_saldoCorrente > 1000)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Conto Aperto !!");
                Console.ForegroundColor = ConsoleColor.White;
                OpenCount = true;
            }

           

            return idConto;
        }

        public bool VisualizzaContoCorrente()
        {
            if (OpenCount == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Impossibile visualizzare il conto Nome e id Conto non trovato");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("ID Conto : " + IdConto);
                Console.WriteLine("Correntista :" + NameConto + " " + CognomeConto);
                Console.WriteLine("Saldo Corrente :" + SaldoCorrente);
                Console.WriteLine("Nome Banca : " + BankName);
            }
            

            return OpenCount;
        }
    }
}
