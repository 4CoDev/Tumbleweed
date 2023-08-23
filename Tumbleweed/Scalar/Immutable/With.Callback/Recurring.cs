using Scalar = Tumbleweed.Scalar.Immutable;
using Procedure = Tumbleweed.Subroutine.Procedure.Nullary;

namespace Tumbleweed.Scalar.Immutable.With.Callback;

public sealed class Recurring<T> : Scalar::Envelope<T>
{
	public Recurring
	(
		T value,
		Procedure::Any callback
	) : this
	(
		new Scalar::With.Value<T>(value),
		callback
	)
	{
	}
	
	public Recurring
	(
		Scalar::Any<T> scalar,
		Procedure::Any callback
	) : base
	(
		new Scalar::Function.Result.Actual<T>(
			() => Function(scalar, callback))
	)
	{
	}
	
	private static T Function
	(
		Scalar::Any<T> scalar,
		Procedure::Any callback
	)
	{
		callback.Invoke();
		return scalar.Value;
	}
}