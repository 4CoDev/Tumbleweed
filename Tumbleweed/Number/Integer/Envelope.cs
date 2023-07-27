namespace Tumbleweed.Number.Integer;

public abstract class Envelope : Integer.Any
{
	protected Envelope(Integer.Any integer) =>
		this.integer = integer;
	
	public Boolean.Any IsPositive =>
		integer.IsPositive;

	public Natural.Any Natural =>
		integer.Natural;

	private readonly Integer.Any integer;
}