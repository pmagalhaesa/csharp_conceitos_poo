using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelevisaoApplication
{
    class Televisao
    {
        private int canal=50;
        private int volume=50;
        private bool ligado=false;

        public int getCanal()
        {
            return this.canal;
        }

        public void setCanal(int canal)
        {
            this.canal = canal;
        }
        public int getVolume()
        {
            return this.volume;
        }
        public void setVolume(int volume)
        {
            this.volume = volume;
        }
        public bool getLigado()
        {
            return this.ligado;
        }
        public void setLigado(bool ligado)
        {
            this.ligado=ligado;
        }

        public void ligarDesligar()
        {
            if (this.ligado==true)
            {
                this.ligado = false;
            }
            else
            {
                this.ligado = true;
            }
        }

        public void aumentarVolume()
        {
            if (this.volume>=0 && this.volume<100)
            {
                this.volume++;
            }            
        }

        public void diminuirVolume()
        {
            if (this.volume > 0 && this.volume <= 100)
            {
                this.volume--;
            }
        }

        public void subirCanal()
        {
            if (this.canal>=1 && this.canal<85)
            {
                this.canal++;
            }
        }

        public void baixarCanal()
        {
            if (this.canal > 1 && this.canal <= 85)
            {
                this.canal--;
            }
        }
    }
}
