﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using AppVenta.Dominio;
using AppVenta.Aplicaciones.Interfaces;
using AppVenta.Dominio.Interfaces.Repositorios;

namespace AppVenta.Aplicaciones.Servicios {

	public class ProductoServicio : IServicioBase<Producto, Guid> {

		private readonly IRepositorioBase<Producto, Guid> repositorio;

		public ProductoServicio(IRepositorioBase<Producto, Guid> _repositorio) {
			repositorio = _repositorio;
		}

		public Producto Agregar(Producto entidad) {
			if (entidad != null) {
				var resultado = repositorio.Agregar(entidad);
				repositorio.GuardarTodosLosCambios();
				return resultado;
			} else
				throw new Exception("Error la entidad no puede ser nula");
		}

		public List<Producto> Listar() {
			return repositorio.Listar();
		}

		public void Editar(Producto entidad) {
			repositorio.Editar(entidad);
			repositorio.GuardarTodosLosCambios();
		}

		public void Eliminar(Guid entidadId) {
			repositorio.Eliminar(entidadId);
			repositorio.GuardarTodosLosCambios();
		}

		public Producto SeleccionarPorID(Guid entidadId) {
			return repositorio.SeleccionarPorID(entidadId);
		}

	}

}
