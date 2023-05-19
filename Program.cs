﻿class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Write("Input half DNA sequence: ");
            string halfDNASequence = Console.ReadLine();

            if (IsValidSequence(halfDNASequence))
            {
                Console.WriteLine("Current half DNA sequence: " + halfDNASequence);

                Console.Write("Do you want to replicate it? (Y/N): ");
                string choice = Console.ReadLine();

                if (choice.ToUpper() == "Y")
                {
                    string replicatedSequence = ReplicateSeqeunce(halfDNASequence);
                    Console.WriteLine("Replicated half DNA sequence: " + replicatedSequence);
                }
                else if (choice.ToUpper() == "N")
                {
                }
                else
                {
                    Console.WriteLine("Please input Y or N.");
                    continue;
                }
            }
            else
            {
                Console.WriteLine("That half DNA sequence is invalid.");
            }
            Console.Write("Do you want to process another sequence? (Y/N): ");
            string restartChoice = Console.ReadLine();
            if (restartChoice.ToUpper() == "Y")
            {
            }
            else if (restartChoice.ToUpper() == "N")
            {
                break;
            }
            else
            {
                Console.WriteLine("Please input Y or N.");
            }
        }
    }
    static bool IsValidSequence(string halfDNASequence)
    {
        foreach (char nucleotide in halfDNASequence)
        {
            if (!"ATCG".Contains(nucleotide))
            {
                return false;
            }
        }
        return true;
    }
    static string ReplicateSeqeunce(string halfDNASequence)
    {
        string result = "";
        foreach (char nucleotide in halfDNASequence)
        {
            result += "TAGC"["ATCG".IndexOf(nucleotide)];
        }
        return result;
    }
}
