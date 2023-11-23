using Tumbleweed.Mathematics.Number.Integer.With.Member;

namespace Tumbleweed.Mathematics.Number.Integer.From.Natural.As;

public sealed class Negative : Tumbleweed.Mathematics.Number.Integer.Envelope
{
	public Negative(Number.Natural.Any natural) : base
	(
		new Definition(
			false,
			natural)
	)
	{
	}
}