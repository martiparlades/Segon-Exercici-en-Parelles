using System;
using System.Collections.Generic;
using System.Threading;

public class Personatge
{

	private int Pos_col;

	public Personatge()
	{
		this.Pos_col = 30;
	}

	public int GetPosicio()
    {
		return Pos_col;
    }

	public void SetPosicio()
    {
		
    }

	public virtual void Moure (ConsoleKeyInfo cki)
    {
		Pos_col--;
    }

	public virtual void Mostrar()
	{
        try
        {
			Console.SetCursorPosition(Pos_col,row);
			Console.Write("e");
		}
        catch (Exception)
        {
			Console.Write("error");
        }
		

	}


}
