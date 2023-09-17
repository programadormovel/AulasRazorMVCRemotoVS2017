using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AulasRazorMVCRemoto.Models
{
    public class DiscoDados
    {
        public List<Disco> listaDisco = new List<Disco>();

        public DiscoDados()
        {
            listaDisco.Add(new Disco
            {
                disco = "Xou da Xuxa",
                artista = "Xuxa",
                faixas = "7"
            });
            listaDisco.Add(new Disco
            {
                disco = "Dois",
                artista = "Legião Urbana",
                faixas = "10"
            });
            listaDisco.Add(new Disco
            {
                disco = "Titanomaquia",
                artista = "Titãs",
                faixas = "9"
            });
            listaDisco.Add(new Disco
            {
                disco = "Cardume",
                artista = "Nenhum de Nós",
                faixas = "11"
            });
            listaDisco.Add(new Disco
            {
                disco = "Black Album",
                artista = "Metallica",
                faixas = "12"
            });
        }

        public void CriaDiscos(Disco discos)
        {
            listaDisco.Add(discos);
        }

        public bool ApagaDisco(string id)
        {
            foreach(Disco discox in listaDisco)
            {
                if(discox.disco == id)
                {
                    listaDisco.Remove(discox);
                    return true;
                }
            }
            return false;
        }

        public void AtualizaDisco(Disco discos)
        {
            foreach(Disco discox in listaDisco)
            {
                if (discox.disco == discos.disco)
                {
                    listaDisco.Remove(discox);
                    listaDisco.Add(discos);
                    break;
                }
            }
        }
    }
}