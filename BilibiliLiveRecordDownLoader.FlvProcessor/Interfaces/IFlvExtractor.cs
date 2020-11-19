using BilibiliLiveRecordDownLoader.Shared.Interfaces;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace BilibiliLiveRecordDownLoader.FlvProcessor.Interfaces
{
	public interface IFlvExtractor : IAsyncDisposable, IProgress
	{
		public int BufferSize { get; init; }

		/// <summary>
		/// 输出时是否使用异步
		/// </summary>
		public bool IsAsync { get; init; }

		/// <summary>
		/// 输出目录
		/// </summary>
		public string? OutputDir { get; init; }

		/// <summary>
		/// 输出的视频路径
		/// </summary>
		public string? OutputVideo { get; }

		/// <summary>
		/// 输出的音频路径
		/// </summary>
		public string? OutputAudio { get; }

		/// <summary>
		/// 提取视频和音频
		/// </summary>
		/// <param name="path">待提取的 FLV 文件</param>
		/// <param name="token"></param>
		/// <returns></returns>
		ValueTask ExtractAsync(string path, CancellationToken token);
	}
}
