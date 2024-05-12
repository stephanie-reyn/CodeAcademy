using System;

namespace CaesarCipher
{
  class Program
  {
    static void Main(string[] args)
    {
      char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
      

      Console.Write("Enter your message: ");
      string inputMsg = Console.ReadLine();
      char[] secretMessage = inputMsg.ToCharArray();
      char[] encryptedMessage = new char [secretMessage.Length];
      
      for (int i = 0; i < secretMessage.Length; i++)
      {
        char letter = secretMessage[i];
        int letterPosition = Array.IndexOf(alphabet, letter);
        int encryptedLetter = (letterPosition + 3) % alphabet.Length; 
        char newLetter = alphabet[encryptedLetter];
        encryptedMessage [i] = newLetter;
      }

      string newMsg = String.Join("", encryptedMessage);
      Console.Write("The new message is: " + newMsg);

      
    }
  }
}

// COMEBACK for extended version
