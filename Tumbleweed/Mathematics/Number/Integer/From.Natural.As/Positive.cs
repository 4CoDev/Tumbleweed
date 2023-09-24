using Tumbleweed.Mathematics.Number.Integer.With.Member;

namespace Tumbleweed.Mathematics.Number.Integer.From.Natural.As;

public sealed class Positive : Tumbleweed.Mathematics.Number.Integer.Envelope
{
	public Positive(Number.Natural.Any natural) : base
	(
		new Definition(
			true,
			natural)
	)
	{
	}
}