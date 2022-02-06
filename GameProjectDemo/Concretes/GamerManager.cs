using GameProjectDemo.Abstracts;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concretes
{
    class GamerManager : IGamerService
    {
        IValidateService _validateService;

        public GamerManager(IValidateService validateService)
        {
            _validateService = validateService;
        }

        public void Add(Gamer gamer)
        {
            if (_validateService.Validate(gamer))
            {
                Console.WriteLine("Kayıt Olundu");
            }
            else
            {
                Console.WriteLine("Kayıt Başarısız, Dogrulama Gerekli");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt Silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt Güncellendi");
        }
    }
}
