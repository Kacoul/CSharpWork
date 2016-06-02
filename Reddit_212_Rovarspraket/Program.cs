using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reddit_212_Rovarspraket
{
    class Rovarspraket_Encryption
    {
        //Encryption program that encodes a string to Rovarspraket
        //consonants are doubled with an o inbetween and vowels are left alone
        //e.g. Kane = Kokanone

        static void Main(string[] args)
        {
            //Define variables
            string input;
            string encrypted_string = "";
            string sym = "o";
            char new_input;

            //Prompt user for string to be encoded
            Console.Write("Enter a string to be encrypted: ");
            input = Console.ReadLine();
            input = input.ToLower();
            
            //array of consonants (Rovarspraket is a Swedish invention therefore Y = vowel as it is in Sweden)
            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            char[] consonants = "bcdfghklnmpqrstvwxz".ToCharArray();
            char[] vowels = "aeiouy".ToCharArray();

            char[] split_input = input.ToCharArray();


            for (int i = 0; i < split_input.Length; i++)
            {
                if(Convert.ToString(split_input[i]) == " ")
                {
                    encrypted_string = encrypted_string + " ";
                }

                for (int a = 0; a < alphabet.Length; a++)
                {
                    if (split_input[i] == alphabet[a])
                    {
                        for (int c = 0; c < consonants.Length; c++)
                        {
                            if (consonants[c] == split_input[i])
                            {
                                if (i == 0)
                                {
                                    new_input = Convert.ToChar(split_input[i]);
                                    new_input = Char.ToUpper(new_input);
                                }
                                else
                                {
                                    new_input = split_input[i];
                                }

                                encrypted_string = encrypted_string + new_input + sym + new_input;
                            }
                        }
                        for (int v = 0; v < vowels.Length; v++)
                        {
                            if (vowels[v] == split_input[i])
                            {
                                if (i == 0)
                                {
                                    new_input = Convert.ToChar(split_input[i]);
                                    new_input = Char.ToUpper(new_input);
                                }
                                else
                                {
                                    new_input = split_input[i];
                                }

                                encrypted_string = encrypted_string + new_input;
                            }
                        }
                    }
                }
            }
            Console.WriteLine(encrypted_string);
        }
    }
}
