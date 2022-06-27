int N = new Random().Next (100, 1000);
string str = N.ToString();
char[] f = str.ToCharArray();
Console.WriteLine (N+ "->" +  f[0].ToString ()+ f[2].ToString ());

