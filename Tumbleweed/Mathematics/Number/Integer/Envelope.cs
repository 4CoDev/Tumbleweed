namespace Tumbleweed.Mathematics.Number.Integer;

public abstract class Envelope : Tumbleweed.Mathematics.Number.Integer.Any
{
	protected Envelope(Any integer) =>
		this.integer = integer;
	
	public Boolean.Any IsPositive =>
		integer.IsPositive;

	public Natural.Any Natural =>
		integer.Natural;

	private readonly Any integer;
}