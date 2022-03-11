using System;

public class MarioBross : Personatge
{

	private const int MAX_VIDA = 3;
	private int Vida;
	public int Pos_row;

	public MarioBross(int col)
	{
		base.SetPosicio(col);
		this.Pos_row = 2;
		Vida = MAX_VIDA;
	}

	public int GetVida()
    {
		return this.Vida;
    }

	public void Moure(ConsoleKeyInfo cki)
    {

    }

	public override void Mostrar()
    {
		
    }

	public virtual bool Update()
    {
		if (this.Pos_row == 1)
        {
			this.Pos_row = 2;
			return true;
        }
        else
        {
			return false;
        }
    }

	public virtual void CheckPosition(List<Personatge> Enemics)
	{

		for (int i = 0; i < Enemics.Count; i++)
        {
			if(Enemics[i].getPosicio() == this.Pos_row - 1)
            {
				Enemics.RemoveAt(i);
				i--;
            }
        }
	}
}
