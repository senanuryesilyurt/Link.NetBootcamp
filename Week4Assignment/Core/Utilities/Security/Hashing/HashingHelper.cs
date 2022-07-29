﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Hashing
{
    public class HashingHelper
    {
        //password ün hash ve salt değerlerini olusturuyor
        //out => boş gelen byte arraylerini doldur ve geri döndür.
        public static void CreatePasswordHash
            (string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            //HMACSHA512 algoritması hem hash hem salt oluşturur.
            using(var hmac=new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }

        //password hash doğruluğunu kontrol ediyor
        public static bool VerifyPasswordHash
            (string password,  byte[] passwordHash,  byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
               var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != passwordHash[i])
                    {
                        return false;
                    }
                }    
            }
            return true;
        }
    }
}
