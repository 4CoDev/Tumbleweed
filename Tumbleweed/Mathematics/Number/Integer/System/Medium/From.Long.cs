using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Function.Result;
using TW = Tumbleweed;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Mathematics.Number.Integer.System.Medium.From;

public sealed class Long : Envelope<Int32>
{
	public Long(Any<Int64> integer) : base
	(
		new Actual<Int32>(
			() => (Int32) integer.Value)
	)
	{
	}
}