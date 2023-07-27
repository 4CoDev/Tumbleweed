namespace Tumbleweed.Number.Integer.From.Natural.As;

public sealed class Positive : Integer.Envelope
{
	public Positive(Number.Natural.Any natural) : base
	(
		new Integer.With.Members(
			true,
			natural)
	)
	{
	}
}