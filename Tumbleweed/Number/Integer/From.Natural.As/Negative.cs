namespace Tumbleweed.Number.Integer.From.Natural.As;

public sealed class Negative : Integer.Envelope
{
	public Negative(Number.Natural.Any natural) : base
	(
		new Integer.With.Members(
			false,
			natural)
	)
	{
	}
}