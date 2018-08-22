using System;
using System.Collections.Generic;
using System.Text;

namespace ElectronicsShop.Core.Tools
{
    public class IdProvider
    {
        private int id = 0;
        private static IdProvider idProvider;

        private IdProvider()
        {
           
        }

        public static IdProvider Instance()
        {
            if (idProvider == null)
            {
                idProvider = new IdProvider();
            }

            return idProvider;
        }

        public int GetID()
        {
            this.id++;
            return this.id;
        }

    }
}
