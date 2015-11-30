﻿namespace VkNet.Model.Auth
{
	public class AuthSignupParams
	{
		/// <summary>
		/// Имя пользователя. строка, обязательный параметр.
		/// </summary>
		public object first_name
		{ get; set; }

		/// <summary>
		/// Фамилия пользователя. строка, обязательный параметр.
		/// </summary>
		public object last_name
		{ get; set; }

		/// <summary>
		/// Идентификатор Вашего приложения. целое число, обязательный параметр.
		/// </summary>
		public object client_id
		{ get; set; }

		/// <summary>
		/// Секретный ключ приложения, доступный в резделе редактирования приложения. строка, обязательный параметр.
		/// </summary>
		public object client_secret
		{ get; set; }

		/// <summary>
		/// Номер телефона регистрируемого пользователя. Номер телефона может быть проверен заранее методом auth.checkPhone. строка, обязательный параметр.
		/// </summary>
		public object phone
		{ get; set; }

		/// <summary>
		/// Пароль пользователя, который будет использоваться при входе. Не меньше 6 символов. Также пароль может быть указан позже, при вызове метода auth.confirm. строка.
		/// </summary>
		public object password
		{ get; set; }

		/// <summary>
		/// 1 — тестовый режим, при котором не будет зарегистрирован новый пользователь, но при этом номер не будет проверяться на использованность. 0 — (по умолчанию) рабочий. флаг, может принимать значения 1 или 0.
		/// </summary>
		public object test_mode
		{ get; set; }

		/// <summary>
		/// 1 — в случае, если вместо SMS необходимо позвонить на указанный номер и продиктовать код голосом. 0 — (по умолчанию) необходимо отправить SMS. В случае если СМС не дошло до пользователя – необходимо вызвать метод повторно указав voice=1 и sid, полученный при первом вызове метода. флаг, может принимать значения 1 или 0.
		/// </summary>
		public object voice
		{ get; set; }

		/// <summary>
		/// Пол пользователя: 1 — женский, 2 — мужской. положительное число.
		/// </summary>
		public object sex
		{ get; set; }

		/// <summary>
		/// Идентификатор сессии, необходимый при повторном вызове метода, в случае если SMS сообщение доставлено не было. При первом вызове этот параметр не передается. строка.
		/// </summary>
		public object sid
		{ get; set; }
	}
}