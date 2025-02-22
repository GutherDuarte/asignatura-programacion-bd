﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronRepositorio.Repositorios {
	interface IRepositorio<Entidad, TipoEntidadId> : IAgregar<Entidad>, IEditar<Entidad>, IEliminar<TipoEntidadId>, IListar<Entidad, TipoEntidadId> {
	}
}
