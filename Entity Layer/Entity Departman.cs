﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer
{
    class Entity_Departman
    {
        private int id;
        private string ad;
        private string acıklama;

        public int Id { get => id; set => id = value; }
        public string Ad { get => ad; set => ad = value; }
        public string Acıklama { get => acıklama; set => acıklama = value; }
    }
}