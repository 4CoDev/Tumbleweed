using Scalar = Tumbleweed.Scalar.Immutable;
using Procedure = Tumbleweed.Subroutine.Procedure.Nullary;

namespace Tumbleweed.Scalar.Immutable.With.Callback;

public sealed class Single<T> : Scalar::Envelope<T>
{
	public Single
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
	
	public Single
	(
		Scalar::Any<T> scalar,
		Procedure::Any callback
	) : base
	(
		new Scalar::Lazy<T>(
			new Scalar::With.Callback.Recurring<T>(scalar, callback))
	)
	{
	}
}