using System;
using System.Collections.Generic;
using System.Threading;

public class Yoshi : Mario
{
	private bool Tongue;

	public Yoshi(int col)
	{
        base.MarioBross();
	}
	public override void Moure(ConsoleKeyInfo cki)
    {
        if (cki.KeyValue == "Spacebar")
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
    }
	public override void CheckPosition(List<Personatge> Enemics)
    {
        base.CheckPosition(Enemics);

        foreach (Personatge character in Enemics)
        {
            if ((character.GetPosicio() == base.pos_col || character.GetPosicio()-1 == base.pos_col) && Tongue)
            {
                Enemics.Remove(character);
            }



    }
}
