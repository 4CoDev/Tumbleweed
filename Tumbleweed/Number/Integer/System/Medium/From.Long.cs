using TW = Tumbleweed;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Number.Integer.System.Medium.From;

public sealed class Long : TW.Scalar.Envelope<Int32>
{
	public Long(TW.Scalar.Any<Int64> integer) : base
	(
		new TW.Scalar.Function.Result<Int32>(
			() => (Int32) integer.Value)
	)
	{
	}
}