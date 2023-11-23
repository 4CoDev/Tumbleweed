using Enumerable = Tumbleweed.Enumerable;
using System = System.Collections.Generic;

namespace Tumbleweed.Enumerable;

public sealed class Reversed<T> : Enumerable::Envelope<T>
{
	public Reversed
	(
		System::IEnumerable<T> enumerable
	) : base
	(
		new Enumerable::Function.Result<T>(
			enumerable.Reverse)
	)
	{
	}
}