using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

public static  class Criptografia
{
    public static string CriptografarMD5Senha(string senha)
    {
        MD5 md5 = MD5.Create();
        byte[] textoEMBytes = md5.ComputeHash(Encoding.UTF8.GetBytes(senha));
        StringBuilder stringBuilder = new StringBuilder();
        for(int i = 0; i < textoEMBytes.Length; i++)
        {
            stringBuilder.Append(textoEMBytes[i].ToString("x2"));
        }
        return stringBuilder.ToString();
    }
}
