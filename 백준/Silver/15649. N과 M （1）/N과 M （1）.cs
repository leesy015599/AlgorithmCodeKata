using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon
{
	internal class Program
	{
		static void Main(string[] argss)
		{
			var args = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
			
			int n = args[0];
            int m = args[1];
            int[] sequence = new int[m];
            StringBuilder sb = new StringBuilder();

            MakeSequence(sequence, n, m, sb);

void MakeSequence(int[] seq, int n, int m, StringBuilder sb)
{
	if (seq.Contains(0) == false)
	{
		for (int j = 0; j < m - 1; j++)
			sb.Append($"{seq[j]} ");
		sb.Append($"{seq[m - 1]}\n");
		Console.Write(sb.ToString());
		sb.Clear();
		seq[m - 1] = 0;
		return ;
	}

	for (int i = 1; i <= n; i++)
	{
		if (seq.Contains(i))
			continue;
		else
		{
			seq[Array.IndexOf(seq, 0)] = i;
			MakeSequence(seq, n, m, sb);
		}
	}
	int idx = Array.IndexOf(seq, 0);
	if (idx != 0)
		seq[idx - 1] = 0;
}
}
    }
}