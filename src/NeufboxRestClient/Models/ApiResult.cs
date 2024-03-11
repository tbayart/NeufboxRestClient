namespace NeufboxRestClient.Models
{
    /// <summary>
    /// Model used to deserialize data embedded in the <see cref="ApiResponse"/>.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ApiResult<T> : ApiResult
    {
        /// <summary>
        /// Initializes a new <see cref="ApiResult{T}"/> instance.
        /// </summary>
        /// <param name="isSuccess">True for an instance in success state, false otherwise.</param>
        protected ApiResult(bool isSuccess) : base(isSuccess) { }

        /// <summary>
        /// The data.
        /// </summary>
        public T Data { get; init; }

        /// <summary>
        /// Provide a new <see cref="ApiResult{T}"/> instance in success state and with data.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static ApiResult<T> Success(T data) => new(true) { Data = data };

        /// <summary>
        /// Provide a new <see cref="ApiResult{T}"/> instance in failure state and with <see cref="ApiError"/>.
        /// </summary>
        /// <param name="error">The <see cref="ApiError"/> instance.</param>
        /// <returns>A new <see cref="ApiResult{T}"/> instance.</returns>
        public static new ApiResult<T> Failure(ApiError error) => new(false) { Error = error };

        /// <summary>
        /// Provide a new <see cref="ApiResult{T}"/> instance in failure state and with <see cref="ApiError"/>.
        /// </summary>
        /// <param name="code">The error code.</param>
        /// <param name="message">The error message.</param>
        /// <returns>A new <see cref="ApiResult{T}"/> instance.</returns>
        public static new ApiResult<T> Failure(int code, string message) => Failure(new ApiError { Code = code, Message = message });
    }

    /// <summary>
    /// Base model used to provide a result.
    /// </summary>
    public class ApiResult
    {
        /// <summary>
        /// Initializes a new <see cref="ApiResult"/> instance.
        /// </summary>
        /// <param name="isSuccess">True for an instance in success state, false otherwise.</param>
        protected ApiResult(bool isSuccess) { IsSuccess = isSuccess; }

        /// <summary>
        /// True is the result is success, false otherwise.
        /// </summary>
        public bool IsSuccess { get; init; }

        /// <summary>
        /// The error details.
        /// </summary>
        public ApiError Error { get; init; }

        /// <summary>
        /// Provide a new <see cref="ApiResult"/> instance in success state.
        /// </summary>
        /// <returns></returns>
        public static ApiResult Success() => new(true);

        /// <summary>
        /// Provide a new <see cref="ApiResult"/> isntance in failure state and with <see cref="ApiError"/>.
        /// </summary>
        /// <param name="error">The <see cref="ApiError"/> instance.</param>
        /// <returns>A new <see cref="ApiResult"/> instance.</returns>
        public static ApiResult Failure(ApiError error) => new(false) { Error = error };

        /// <summary>
        /// Provide a new <see cref="ApiResult"/> isntance in failure state and with <see cref="ApiError"/>.
        /// </summary>
        /// <param name="code">The error code.</param>
        /// <param name="message">The error message.</param>
        public static ApiResult Failure(int code, string message) => Failure(new ApiError { Code = code, Message = message });
    }
}
