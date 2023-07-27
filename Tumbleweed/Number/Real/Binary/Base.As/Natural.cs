namespace Tumbleweed.Number.Real.Binary.Base.As;

public sealed class Natural : Number.Natural.Envelope
{
	public Natural() : base
	(
		new Number.Natural.From.System.One(2)
	)
	{
	}
}