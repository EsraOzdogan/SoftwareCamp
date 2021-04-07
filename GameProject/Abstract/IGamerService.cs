﻿using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface IGamerService //IGamerService
    {
        //gamerı sisteme ekle,güncelle,sil(operasyon isimleri)
        void Add(Gamer gamer); 
        void Update(Gamer gamer);
        void Delete(Gamer gamer);
    }
}
