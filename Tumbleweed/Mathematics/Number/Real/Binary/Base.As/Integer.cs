using Tumbleweed.Mathematics.Number.Integer.From.Natural.As;

namespace Tumbleweed.Mathematics.Number.Real.Binary.Base.As;

public sealed class Integer : Tumbleweed.Mathematics.Number.Integer.Envelope
{
	public Integer() : base
	(
		new Positive(
			new Natural())
	)
	{
	}
}