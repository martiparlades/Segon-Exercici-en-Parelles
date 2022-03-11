using System;
using System.Collections.Generic;
using System.Threading;

public class Yoshi : MarioBross
{
	private bool Tongue;

	public Yoshi(int col) : base(col)
	{
        int pos_row = 2;
	}
	public override void Moure(ConsoleKeyInfo cki)
    {
        if (cki.Key == ConsoleKey.Spacebar)
        {
            Tongue = true;
        }
        else
        {
            base.Moure(cki);
        }
    }
	public override void Mostrar()
    {

    }
	public override bool Update()
    {
        Tongue=false;
        base.Update();
        return Tongue;
    }
	public override void CheckPosition(List<Personatge> Enemics)
    {
        base.CheckPosition(Enemics);

        foreach (Personatge character in Enemics)
        {
            if ((character.GetPosicio() == base.Pos_row || character.GetPosicio()-1 == base.Pos_row) && Tongue)
            {
                Enemics.Remove(character);
            }



    }
}
