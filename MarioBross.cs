using System;

public class MarioBross : Personatge
{

	private const int MAX_VIDA = 3;
	private int Vida;
	protected int Pos_row;

	public MarioBross(int col)
	{
		this.Pos_row = 2;
		Vida = MAX_VIDA;
	}

	public int GetVida()
    {
		return Vida;
    }

	public void Moure(ConsoleKeyInfo cki)
    {

    }

	public void Mostrar()
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
		foreach (Personatge character in Enemics)
        {
			if(character.GetPosicio() -1 == this.Pos_row)
            {
				Enemics.Remove(character);
            }
			if (character.GetPosicio() == this.Pos_row)
            {
				this.Vida--;
            }
        }
	}
}
