namespace Tumbleweed.Number.Real.Binary.Base.As;

public sealed class Integer : Number.Integer.Envelope
{
	public Integer() : base
	(
		new Number.Integer.From.Natural.As.Positive(
			new Natural())
	)
	{
	}
}