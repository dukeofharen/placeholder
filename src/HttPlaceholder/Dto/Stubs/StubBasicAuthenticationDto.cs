﻿using YamlDotNet.Serialization;

namespace HttPlaceholder.Dto.Stubs
{
    /// <summary>
    /// A model for storing stub information for the basic authentication condition checker.
    /// </summary>
    public class StubBasicAuthenticationDto
    {
        /// <summary>
        /// Gets or sets the username.
        /// </summary>
        [YamlMember(Alias = "username")]
        public string Username { get; set; }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        [YamlMember(Alias = "password")]
        public string Password { get; set; }

        /// <summary>
        /// Returns a <see cref="string" /> that represents this instance.
        /// </summary>
        public override string ToString()
        {
            return $"[Username = '{Username}', Password = '{Password}']";
        }
    }
}