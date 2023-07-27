// ReSharper disable once CheckNamespace
namespace Tumbleweed.Number.Real.Comparison.Is.Greater.Than.Number;

public sealed class Zero : Boolean.Envelope
{
	public Zero
	(
		Real.Any greater
	) : base
	(
		new One(
			greater,
			new Binary.Precision.Single.From.System.One(0))
	)
	{
	}
}