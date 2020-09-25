using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using cenope.Models;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using SistemaDeProveedores.Models;
using Microsoft.EntityFrameworkCore;

namespace cenope.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LogInController : ControllerBase
    {
        private readonly IConfiguration configuration;
        private readonly SistemaProveedoresContextClass context;
        // TRAEMOS EL OBJETO DE CONFIGURACIÓN (appsettings.json)
        // MEDIANTE INYECCIÓN DE DEPENDENCIAS.
        public LogInController(IConfiguration configuration)
        {
            this.configuration = configuration;
            this.context = context;
        }

        // POST: api/Login
        [HttpPost]
        [AllowAnonymous]
        public IActionResult Login([FromBody] string value)
        {
            //Usuario usuario = await AutenticarTokenAsync();
            //if (usuario != null)
            //{
            //    return Ok(new { token = GenerarTokenJWT(usuario), usuario = usuario.Uid, display = usuario.Nombre, rol = usuario.Rol, email = usuario.Email });
            //}
            //else
            //{
            //    return Unauthorized();
            //}
            //return Ok(new { data = value });
            return Unauthorized();
        }

        // COMPROBAMOS SI EL USUARIO EXISTE EN LA BASE DE DATOS 
        private async Task<Usuario> AutenticarTokenAsync(string id, string password)
        {
            byte[] data = Encoding.ASCII.GetBytes(password);
            data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
            String hash = Encoding.ASCII.GetString(data);

            // AQUÍ LA LÓGICA DE AUTENTICACIÓN //
            return await context.Usuarios.Where(x => x.Uid == id).Where(x => x.Uid == id).FirstOrDefaultAsync();

            // Supondremos que el Usuario existe en la Base de Datos.
            // Retornamos un objeto del tipo UsuarioInfo, con toda
            // la información del usuario necesaria para el Token.
            if (true)
            {
                return new Usuario()
                {
                    Id = new Guid("B5D233F0-6EC2-4950-8CD7-F44D16EC878F"),
                    Nombre = "Usuario Apellido",
                    Uid = "uapellido",
                    Email = "usuario@dominio.com",
                    Rol = "ADMIN"
                };
            }
            else
            {
                return null;
            }
        }

        // GENERAMOS EL TOKEN CON LA INFORMACIÓN DEL USUARIO
        private string GenerarTokenJWT(Usuario usuario)
        {
            // CREAMOS EL HEADER //
            var _symmetricSecurityKey = new SymmetricSecurityKey(
                    Encoding.UTF8.GetBytes(configuration["JWT:ClaveSecreta"])
                );
            var _signingCredentials = new SigningCredentials(
                    _symmetricSecurityKey, SecurityAlgorithms.HmacSha256
                );
            var _Header = new JwtHeader(_signingCredentials);

            // CREAMOS LOS CLAIMS //
            var _Claims = new[] {
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.NameId, usuario.Id.ToString()),
                new Claim("uid", usuario.Uid),
                new Claim(JwtRegisteredClaimNames.Email, usuario.Email),
                new Claim(ClaimTypes.Role, usuario.Rol)
            };

            // CREAMOS EL PAYLOAD //
            var _Payload = new JwtPayload(
                    issuer: configuration["JWT:Issuer"],
                    audience: configuration["JWT:Audience"],
                    claims: _Claims,
                    notBefore: DateTime.UtcNow,
                    // Exipra en 24 horas.
                    expires: DateTime.UtcNow.AddHours(24)
                );

            // GENERAMOS EL TOKEN //
            var _Token = new JwtSecurityToken(
                    _Header,
                    _Payload
                );

            return new JwtSecurityTokenHandler().WriteToken(_Token);
        }
    }
}
