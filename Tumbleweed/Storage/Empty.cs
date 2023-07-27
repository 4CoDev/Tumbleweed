using System = System;

namespace Tumbleweed.Storage;

public sealed class Empty : Envelope
{
	public Empty() : base
	(
		new From.Dictionary(
			new Dictionary<System::Object, System::Object>())
	)
	{
	}
}