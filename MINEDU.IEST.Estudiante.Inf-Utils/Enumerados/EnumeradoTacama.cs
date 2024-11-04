namespace MINEDU.IEST.Estudiante.Inf_Utils.Enumerados
{

    public enum EnumTIPO_PERSONA
    {
        JURIDICA = 102001,
        NATURAL_CON_RUC = 102002,
        NATURAL_SIN_RUC = 102003,
        OTROS = 102004
    }

    public enum EnumTABLA_2_TIPO_DE_DOCUMENTO_DE_IDENTIDAD
    {
        DNI = 101001,
        CARNET_DE_EXTRANJERIA = 101002,
        RUC = 101004,
        OTROS = 101005,
        PASAPORTE = 101006,
        GG = 101007
    }

    public enum EnumTIPO_SITUACION_TEMPORADA
    {
        ABIERTO = 103001,
        CERRADO = 103002,
        ANULADO = 103003
    }

    public enum EnumTIPO_CLIENTE
    {
        AGRICULTOR = 104001,
        AGROINDUSTRIA = 104002,
        COMISIONISTA = 104003,
        CANAL_DISTRIBUIDOR_FRANQUICIATARIO = 104004,
        MAYORISTA = 104005,
        NORMAL = 104006,
        HABILITADOR = 104007,
        VIVERO = 104008,
        TOP_POTENCIAL = 104009,
        REFERENTES = 104010,
        IMPORTADOR_DIRECTO = 104011,
        CLIENTES_INTERNOS = 104012,
        ALMACENES_PORTUARIOS = 104013
    }

    public enum EnumTIPO_COMPROBANTE_PAGO
    {
        FACTURA = 105001,
        BOLETA = 105002,
        GUIA_DE_REMISION = 105004,
        SOLO_FACTURA = 105005,
        SOLO_BOLETA = 105006
    }

    public enum EnumTIPO_MERCADO
    {
        NACIONAL = 106001,
        EXPORTACION = 106002
    }

    public enum EnumTIPO_DIRECCION
    {
        PRINCIPAL = 107001,
        TRABAJO = 107002,
        FAMILIAR = 107003
    }

    public enum EnumTIPO_VIA
    {
        AV = 108001,
        CALLE = 108002,
        JR = 108003,
        F = 108004,
        ZSGG = 108005
    }

    public enum EnumTIPO_ZONA
    {
        URBANIZACION = 109001,
        ASENTAMIENTO_HUMANO = 109002,
        PUEBLO_JOVEN = 109003
    }

    public enum EnumTABLA_25_CONVENIOS_PARA_EVITAR_LA_DOBLE_TRIBUTACIÓN
    {
        NINGUNO = 110001,
        CANADA = 110002,
        CHILE = 110003,
        COMUNIDAD_ANDINA_DE_NACIONES_CAN = 110004,
        BRASIL = 110005,
        ESTADOS_UNIDOS_MEXICANOS = 110006,
        REPUBLICA_DE_COREA = 110007,
        CONFEDERACIÓN_SUIZA = 110008,
        PORTUGAL = 110009,
        OTROS = 110010
    }

    public enum EnumTABLA_27_TIPO_DE_VINCULACION_ECONOMICA
    {
        SIN_VINCULACIÓN = 112001,
        UNA_PERSONA_NATURAL_O_JURÍDICA_POSEA_MÁS_DE_30_DEL_CAPITAL_DE_OTRA_PERSONA_JURIDICA = 112002,
        MÁS_30_DEL_CAPITAL_DE_2_O_MÁS_PERSONAS_JURÍDICAS_PERTENEZCA_A_UNA_MISMA_PERSONA_NATURAL_O_JURÍDICA = 112003,
        EN_CUALESQUIERA_DE_LOS_CASOS_ANTERIORES_CUANDO_LA_INDICADA_PROPORCIÓN_DEL_CAPITAL_PERTENEZCA_A_CÓNY = 112004,
        EL_CAPITAL_DE_2_O_MÁS_PERSONAS_JURÍDICAS_PERTENEZCA_EN_MÁS_DEL_30_A_SOCIOS_COMUNES_A_ESTAS = 112005,
        LAS_PERSONAS_JURÍDICAS_O_ENTIDADES_CUENTEN_CON_UNA_O_MÁS_DIRECTORES_GERENTES_ADMINISTRADORES_U_OTR = 112006,
        DOS_O_MÁS_PERSONAS_NATURALES_O_JURÍDICAS_CONSOLIDEN_ESTADOS_FINANCIEROS = 112007,
        EXISTA_UN_CONTRATO_DE_COLABORACIÓN_EMPRESARIAL_CON_CONTABILIDAD_INDEPENDIENTE = 112008,
        EN_EL_CASO_DE_UN_CONTRATO_DE_COLABORACIÓN_EMPRESARIAL_SIN_CONTABILIDAD_INDEPENDIENTE = 112009,
        EXISTA_UN_CONTRATO_DE_ASOCIACIÓN_EN_PARTICIPACIÓN_EN_EL_QUE_ALGUNO_DE_LOS_ASOCIADOS_DIRECTA_O_INDI = 112010,
        UNA_EMPRESA_NO_DOMICILIADA_TENGA_UNO_O_MAS_ESTABLECIMIENTOS_PERMANENTES_EN_EL_PAÍS = 112011,
        UNA_EMPRESA_DOMICILIADA_EN_TERRITORIO_PERUANO_TENGA_UNO_O_MAS_ESTABLECIMIENTOS_PERMANENTES_EN_EL_EXT = 112012,
        UNA_PERSONA_NATURAL_O_JURÍDICA_EJERZA_INFLUENCIA_DOMINANTE_EN_LAS_DECISIONES_DE_LOS_ÓRGANOS_DE_ADMIN = 112013
    }

    public enum EnumTABLA_32_MODALIDAD_DEL_SERVICIO_PRESTADO_POR_EL_SUJETO_NO_DOMICILIADO
    {
        SERVICIO_PRESTADO_INTEGRAMENTE_EN_EL_PERÚ = 113001,
        SERVICIO_PRESTADO_PARTE_EN_EL_PERÚ_Y_PARTE_EN_EL_EXTRANJERO = 113002,
        SERVICIO_PRESTADO_EXCLUSIVAMENTE_EN_EL_EXTRANJERO = 113003
    }

    public enum EnumTABLA_33_EXONERACIONES_DE_OPERACIONES_DE_NO_DOMICILIADOS_ART_19_DE_LA_LEY_DEL_IMPUESTO_A_LA_RENTA
    {
        LOS_INTERESES_PROVENIENTES_DE_CRÉDITOS_DE_FOMENTO_OTORGADOS_DIRECTAMENTE_O_MEDIANTE_PROVEEDORES = 114001,
        LAS_RENTAS_DE_LOS_INMUEBLES_DE_PROPIEDAD_DE_ORGANISMOS_INTERNACIONALES_QUE_LES_SIRVAN_DE_SEDE = 114002,
        LAS_REMUNERACIONES_QUE_PERCIBAN_POR_EL_EJERCICIO_DE_SU_CARGO_EN_EL_PAÍS = 114003,
        LOS_INGRESOS_BRUTOS_QUE_PERCIBEN_LAS_REPRESENTACIONES_DEPORTIVAS_NACIONALES_DE_PAÍSES_EXTRANJEROS_PO = 114004,
        LAS_REGALÍAS_POR_ASESORAMIENTO_TÉCNICO_ECONÓMICO_FINANCIERO_O_DE_OTRA_ÍNDOLE_PRESTADOS_DESDE_EL_ = 114005,
        LOS_INGRESOS_EXTRANJEROS_POR_LOS_ESPECTÁCULOS_EN_VIVO_DE_TEATRO_ZARZUELA_CONCIERTOS_DE_MÚSICA_CLÁS = 114006
    }

    public enum EnumTIPO_UNIDAD_MEDIDA
    {
        UNIDAD = 116001,
        LONGITUD = 116002,
        MASA_O_PESO = 116003,
        VOLUMEN = 116004,
        CAPACIDAD = 116005,
        SUPERFICIE = 116006
    }

    public enum EnumTIPO_USO
    {
        MUESTRA = 118001,
        MERCADERIA = 118002,
        SERVICIO = 118003,
        ANTICIPO = 118004
    }

    public enum EnumTIPO_REPORTE_DE_CONCILIACION
    {
        REPORTE_CONCILIACION_1 = 122001,
        REPORTE_CONCILIACION_2 = 122002,
        REPORTE_CONCILIACION_3 = 122003
    }

    public enum EnumTIPO_ARTICULO
    {
        FAJA = 124001,
        FILTRO = 124002,
        CUCHILLA = 124003,
        VIDRIO = 124004,
        ESCOBILLA_DC = 124005,
        ENCHUFE = 124006,
        BOBINA = 124007
    }

    public enum EnumTIPO_SITUACION_MUESTRA
    {
        REGISTRADO = 126001,
        PENDIENTE = 126002,
        APROBADO_JV = 126003,
        APROBADO_JD = 126004
    }

    public enum EnumTIPO_LIQUIDACION
    {
        VENTAS = 130001,
        ADMINISTRACION = 130002,
        PRODUCCION = 130003
    }

    public enum EnumCLASES_ALMACEN
    {
        MECANICO = 134001,
        PRODUCCION = 134002,
        PORTUARIOS = 134003,
        ADMINISTRATIVO = 134004
    }

    public enum EnumTIPO_APLICACION
    {
        APLICACION_WEB = 136001,
        APLICACION_ESCRITORIO = 136002
    }

    public enum EnumTIPO_VEHICULO
    {
        MOTOCICLETA = 137001,
        AUTO = 137002,
        FURGONETA = 137003,
        CAMION = 137004
    }

    public enum EnumTIPO_MARCA
    {
        NISSAN = 138001,
        TOYOTA = 138002,
        KIA = 138003,
        RENAULT = 138004,
        SUBARU = 138005,
        HYUNDAI = 138006
    }

    public enum EnumTIPO_MODELO
    {
        YARIS = 139001,
        SENTRA = 139002,
        RIO = 139003,
        ELANTRA = 139004,
        SANTAFE = 139005
    }

    public enum EnumCORRELATIVO
    {
        RANGO = 140001,
        BOLETA = 140002,
        FACTURA = 140003,
        GUIA_REMISION = 140004,
        INGRESO_POR_COMPRA_LOCAL = 140005,
        NOTA_DE_CREDITO = 140006,
        CUENTAS_POR_COBRAR = 140007,
        CALZADO_DE_DAMA = 140008,
        PRESTAMO_A_CLIENTE = 140009
    }

    public enum EnumTIPO_LICENCIA
    {
        A1 = 141001,
        A2 = 141002,
        A3 = 141003,
        A2II = 141004
    }

    public enum EnumTIPO_CARACTERISTICA
    {
        TEXTURA = 142001,
        GROSOR = 142002,
        ALTURA = 142003,
        MARCA = 142004,
        CUADRADO = 142005,
        EJE1 = 142006
    }

    public enum EnumTIPO_FORMA_PAGO
    {
        CONTADO = 143001,
        TARJETA_MASTERCARD = 143002,
        TARJETA_VISA = 143003,
        TARJETA_OTRA = 143004,
        NOTA_DE_CREDITO = 143005,
        CREDITO = 143006,
        CHEQUE = 143007,
        DEPOSITO_EN_CUENTA = 143008,
        TRANSFERENCIA_CUENTA = 143009,
        TRASFERENCIA_GRATUITA = 143010,
        LETRA_CAMBIO = 143011,
        VUELTO = 143012,
        TRANSFERENCIA_BANCARIA = 143013
    }

    public enum EnumMODALIDAD_DE_ORDEN_COMPRA
    {
        COMPRAS_SIN_SIG = 144001,
        COMPRAS_CON_SIG = 144002
    }

    public enum EnumTIPO_SITUACION_ORDEN_PEDIDO
    {
        PENDIENTE = 145001,
        PROCESADO = 145002,
        DIGITADO = 145003,
        EN_PRODUCCION = 145004,
        CONFIRMADO = 145005,
        ANULADA = 145006,
        RECHAZADO = 145008,
        RECEPCIONADO = 145009,
        EN_TRANSITO = 145010,
        DESPACHADO = 145011
    }

    public enum EnumTIPO_DE_SITUACION_FORMULARIO
    {
        ACTIVO = 146001,
        INACTIVO = 146002
    }

    public enum EnumTIPO_SOLICITUD_PRODUCCION
    {
        POR_MUESTRA = 147001,
        POR_OPEDIDO = 147002,
        POR_MANTENIMIENTO = 147003
    }

    public enum EnumTIPO_SITSOLICITUD_PRODUCCION_PROCESO
    {

        REGISTRADO = 148001,
        EN_PROCESO = 148002,
        CERRADO = 148003,
        ANULADO = 148004,
        PENDIENTE = 148006
    }

    public enum EnumSITUACION_SOLICITUD_PRODUCCION_INSUMO
    {
        PENDIENTE = 149001,
        PARCIAL = 149002,
        ATENDIDO = 149003
    }

    public enum EnumTIPO_PREFINITO
    {
        CUÑA = 150001,
        PLATAFORMA = 150002,
        PLANTA = 150003,
        SUELA = 150004,
        CUERO = 150005
    }

    public enum EnumSITUACION_TARJETAS_PROCESO
    {
        PENDIENTE = 151001,
        REGISTRADO = 151002,
        EN_PROCESO = 151003,
        CERRADO = 151004,
        ANULADA = 151005,
        DESPACHADA = 151006
    }

    public enum EnumTIPO_GASTO_MOVILIDAD
    {
        ADMINISTRATIVO = 152001,
        VENTAS = 152002
    }

    public enum EnumTIPO_ACTIVIDAD
    {
        ACT, INTERNA = 153001,
        ACTEXTERNA = 153002
    }

    public enum EnumTIPO_ORIGEN_ACT_PRODUCTIVA
    {

        REGULAR = 154001,
        ADICIONAL = 154002
    }

    public enum EnumTIPO_PAGO_ACT
    {
        PAGO_EMPRESA = 155001,
        PAGO_TRABAJADOR = 155002
    }

    public enum EnumSITUACION_ACTIVIDAD
    {
        REGISTRADO = 156001,
        PENDIENTE = 156002,
        APROBADO = 156003
    }

    public enum EnumTIPO_DESPACHO
    {
        DESPACHO_POR_PEDIDO = 157001,
        DESPACHO_POR_MANTENIMIENTO = 157002
    }

    public enum EnumSITUACION_DESPACHO
    {
        PENDIENTE = 158001,
        ATENDIDA = 158002,
        ANULADA = 158003
    }

    public enum EnumSITUACION_SERIE
    {
        PENDIENTE = 159001,
        ASIGNADO = 159002,
        PROCESADO = 159003
    }

    public enum EnumSITUACION_SOLICITUD_PRODUCCION_ENTREGA
    {
        PENDIENTE = 160001,
        ATENDIDA = 160002
    }

    public enum EnumMOTIVOS_DE_TRASLADO
    {
        VENTA = 161001,
        VENTA_SUJETA_A_CONFIRMACION_DEL_COMPRADOR = 161002,
        COMPRA = 161003,
        TRASLADO_ENTRE_ESTABLECIMIENTO_MISMA_EMPRESA = 161004,
        TRASLADO_EMISOR_ITINERANTE_CP = 161005,
        IMPORTACION = 161006,
        EXPORTACION = 161007,
        TRASLADO_A_ZONA_PRIMARIA = 161008,
        OTROS = 161009,
        CONSIGNACION = 161010,
        DEVOLUCION = 161011,
        TRASALADO_DE_BIENES_DE_TRANSFORMACION = 161012
    }

    public enum EnumSUB_ALMACEN
    {
        DISPONIBLE = 162001,
        EXTERNO = 162002,
        EXHIBICION = 162003,
        PRESTAMO = 162004,
        SEPARACION_CLIENTE = 162005,
        SEPARACION = 162006,
        MANTENIMIENTO_GENERICO = 162007,
        PRODUCCION = 162008,
        SEPARACION_INSUMO = 162009,
        SEPARACION_DESPACHO = 162010
    }

    public enum EnumTIPO_SITUACION_GUIA_REMISION
    {
        PENDIENTE = 164001,
        RECIBIDA = 164002,
        FACTURADA = 164003,
        ANULADA = 164004
    }

    public enum EnumTIPOS_DE_SITUACION_DE_ALBARAN_
    {
        PENDIENTE = 166001,
        REGISTRADO = 166002,
        PROCESADO_ = 166003,
        ANULADO = 166004,
        CERRADA = 166005
    }

    public enum EnumTIPO_ORIGEN_COMPROBANTE_PAGO
    {
        VENTA_CORPORATIVA = 167001,
        VENTA_BASICA = 167002
    }

    public enum EnumTIPO_SITUACION_COMPROBANTE_PAGO
    {
        REGISTRADO = 168001,
        CANCELADO = 168002,
        ANULADO = 168003,
        APLICADO = 168004,
        PROCESO = 168005
    }

    public enum EnumMOVIMIENTO_DE_ALMACEN
    {
        INGRESO_POR_COMPRA_LOCAL = 169001,
        INGRESO_POR_COMPRA_AL_EXTERIOR = 169002,
        INGRESO_POR_DEVOLUCION_AL_CLIENTE = 169003,
        INGRESO_POR_TRANSFORMACION = 169004,
        INGRESO_POR_PRODUCCION = 169005,
        INGRESO_POR_CONSIGNACION = 169006,
        INGRESO_POR_CONCESION = 169007,
        INGRESO_POR_REGULARIZACION_DE_INVENTARIO = 169008,
        TRANSFERENCIA_DE__INGRESO_POR_MOVIMIENTO_DE_TERCEROS = 169009,
        TRANSFERENCIA_DE__INGRESO_POR_MOVIMIENTO_HACIA_TERCEROS_ = 169010,
        TRANSFERENCIA_ENTRE_SUBALMACENES = 169011,
        TRANSFERENCIA_DE__SALIDA_POR_MOVIMIENTO_DE_TERCEROS = 169012,
        TRANSFERENCIA_DE_SALIDA_POR_MOVIMIENTO_HACIA_TERCEROS = 169013,
        TRANSFERENCIA_DE_SALIDA_POR_PRESTAMO_RECIBIDO = 169014,
        TRANSFERENCIA_DE_INGRESO_POR_PRESTAMO_RECIBIDO_ = 169015,
        TRANSFERENCIA_DE_SALIDA_POR_PRESTAMO_ENTREGADO_ = 169016,
        TRANSFERENCIA_DE_INGRESO_POR_PRESTAMO_ENTREGADO = 169017,
        TRANSFERENCIA_DE_SALIDA_ENTRE_ALMACENES_INTERNOS = 169018,
        TRANSFERENCIA_DE_INGRESO_ENTRE_ALMACENES_INTERNOS_ = 169019,
        TRANSFERENCIA_DE_INGRESO_POR_MOVIMIENTO_GENERICO = 169020,
        TRANSFERENCIA_DE_SALIDA_POR_MOVIMIENTO_GENERICO_ = 169021,
        SALIDA_POR_VENTA_ = 169022,
        SALIDA_DE_INSUMOS_POR_PRODUCCION_ = 169023,
        SALIDA_POR_TRANSFORMACION_ = 169024,
        SALIDA_DE_REGULARIZACION_POR_INVENTARIO_ = 169025,
        SALIDA_POR_MERMA_ = 169026,
        SALIDA_POR_OBSOLESCENCIA_ = 169027,
        SALIDA_POR_DEVOLUCION_A_PROVEEDOR_ = 169028,
        SALIDA_POR_DEVOLUCION_A_CONSIGNATARIO_ = 169029,
        SALIDA_POR_DEVOLUCION_A_CONCESIONARIO_ = 169030
    }

    public enum EnumTIPO_REQUERIMIENTO_DE_INSUMO
    {
        REPOSICION = 170001,
        DE_PRODUCCION = 170002,
        COMPRA_DE_ACTIVO = 170003
    }

    public enum EnumSITUACION_REQUERIMIENTO_INSUMO
    {
        REGISTRADO = 171001,
        ATENDIDO = 171002,
        ANULADO = 171003,
        EN_ORDEN_DE_COMPRA = 171004
    }

    public enum EnumSITUACIONREQUERIMIENTO_ITEM
    {
        PENDIENTE = 172001,
        PARCIAL = 172002,
        ATENDIDO = 172003,
        ANULADO = 172004,
        EN_COMPRA = 172005
    }

    public enum EnumMODALIDAD_ORDEN_COMPRA
    {
        COMPRA = 173001,
        CONSIGNACION = 173002,
        CONCESION = 173003
    }

    public enum EnumTIPO_IMPRESION
    {
        IMPRESION_1 = 174001,
        IMPRESION_2 = 174002
    }

    public enum EnumSITUACION_ORDEN_DE_COMPRA
    {
        PENDIENTE = 175001,
        EMITIDO = 175002,
        ATENDIDO = 175003,
        ANULADO = 175004
    }

    public enum EnumSITUACION_ORDEN_DE_DEVOLUCION
    {
        REGISTRADO_ = 176001,
        PROCESADO = 176002
    }

    public enum EnumTIPO_DIA
    {
        LABORABLE = 178001,
        NO_LABORABLE = 178002,
        FERIADO = 178003
    }

    public enum EnumTIPO_CUENTA_PAGAR
    {
        COMPRA_AL_EXTERIOR = 179001,
        COMPRA_LOCAL = 179002,
        RECIBO_POR_HONORARIO = 179003
    }

    public enum EnumESTADOS_CUENTAS_POR_PAGAR
    {
        NO_GENERADO = 181001,
        EMITIDO = 181002,
        CONTABILIZADO = 181003,
        ANULADO = 181004
    }

    public enum EnumTIPO_APLICACION_NOTA_CREDITO
    {
        POR_MONTO_TOTAL = 183001,
        POR_ITEMS = 183002
    }

    public enum EnumESTADOS_DE_MOV_ALMACEN
    {
        PENDIENTE = 184001,
        REGISTRADO = 184002,
        ANULADO = 184003
    }

    public enum EnumTIPO_ORDEN_DE_MANTENIMIENTO
    {
        GENERICA = 185001,
        COMPOSTURA = 185002,
        DEVOLUCION = 185003
    }

    public enum EnumORIGEN_ORDEN_DE_COMPRA
    {
        CON_REQUISICION = 186001,
        CON_ADJUDICACION = 186002,
        SIN_REQUISICION = 186003
    }

    public enum EnumSITUACION_ORDEN_MANTENIMIENTO
    {
        PENDIENTE = 187001,
        REGISTRADO = 187002,
        PROCESADO = 187003,
        ANULADO = 187004,
        CERRADO = 187005
    }

    public enum EnumTIPO_DE_IMPRESION_POR_FACTURA
    {
        REGULAR_ = 188001,
        EXPORTACION = 188002,
        AGRUPADO = 188003
    }

    public enum EnumIMPRESION_DE_GUIA_REMISION
    {
        VENTA = 189001,
        EXPORTACION = 189002,
        TRASLADO = 189003
    }

    public enum EnumTIPOS_DE_VALORES
    {
        IGV = 190001,
        ITF = 190002,
        UIT = 190003
    }

    public enum EnumTIPO_DESTINO_DE_VENTA
    {
        NACIONAL = 191001,
        LOCAL = 191002,
        INTERNACIONAL = 191003
    }

    public enum EnumTIPO__SERVICIOS
    {
        DESCUENTO = 192001,
        GENERICO = 192002
    }

    public enum EnumTIPO_SITUACION_CAJA_VENTA

    {
        REGISTRADO = 193001,
        ABIERTO_ = 193002,
        CERRADO_ = 193003,
        ARQUEADA = 193004

    }

    public enum EnumTIPO_DIAS_SEMANA
    {
        LUNES = 194001,
        MARTES = 194002,
        MIERCOLES = 194003,
        JUEVES = 194004,
        VIERNES = 194005,
        SABADO = 194006,
        DOMINGO = 194007
    }

    public enum EnumTIPO_VENTA
    {
        PEDIDO_CLIENTE = 195001,
        SIN_PEDIDO = 195002,
        ANTICIPOS = 195003,
        DIFERIDA = 195004,
        INSUMOS = 195005,
        ACTIVO_FIJO = 195006,
        SOBRANTES = 195007,
        VALE = 195008
    }

    public enum EnumTIPO_FACTURACION
    {
        MERCADERIA = 196001,
        SIN_ENTREGA = 196002,
        OTRAS_VENTAS = 196003,
        POR_VALE = 196004
    }

    public enum EnumTIPO_MOVIMIENTO_PLANILLA
    {
        INGRESO = 197001,
        EGRESO = 197002,
        PATRONAL = 197003,
        PROVISION = 197004
    }

    public enum EnumTIPO_VALOR_PLANILLA
    {
        PORCENTAJE = 198001,
        MONTO = 198002
    }

    public enum EnumTIPO_TRIBUTO_PLANILLA
    {
        TRIBUTO = 199001,
        BENEFICIO = 199002,
        LIQ_BENEFICIOS_SOCIALES = 199003
    }

    public enum EnumSITUACION_LETRA_CAMBIO
    {
        PENDIENTE = 200001,
        APROBADO = 200002,
        CANCELADO = 200003,
        ANULADO = 200004
    }

    public enum EnumSITUACION_CANJE_LETRA
    {
        PENDIENTE = 201001,
        REGISTRADO = 201002,
        ANULADO = 201003
    }

    public enum EnumTIPO_ENTIDAD
    {
        EMPLEADO = 202001,
        TRABAJADOR = 202002,
        PROVEEDOR = 202003,
        BANCOS = 202004,
        LOCAL = 202005,
        AREA = 202006
    }

    public enum EnumTIPO_TRABAJADOR_
    {
        EJECUTIVO = 204001,
        OBRERO = 204002,
        EMPLEADO = 204003,
        TRABAJADOR_PORTUARIO = 204004,
        PRACTICANTE_SENATI = 204005,
        PENSIONISTA_O_CESANTE = 204006,
        PENSIONISTA_LEY_28320 = 204007,
        CONSTRUCCIÓN_CIVIL = 204008,
        PILOTO_Y_COPILOTO_DE_AVIA_COM = 204009,
        MARÍTIMO_FLUVIAL_O_LACUSTRE = 204010,
        PERIODISTA = 204011,
        TRAB_DE_LA_INDUSTRIA_DE_CUERO = 204012,
        MINERO_DE_MINA_DE_SOCAVÓN = 204013,
        PESCADOR_LEY_28320 = 204014,
        MINERO_DE_TAJO_ABIERTO = 204015,
        MINERO_DE_INDUSTRIA_MINERA_METALÚRGICA = 204016,
        ARTISTA_LEY_DEL_ARTISTA_LEY_28131 = 204017,
        AGRARIO_DEPENDIENTE_LEY_27360 = 204018,
        TRABAJADOR_ACTIVIDAD_ACUÍCOLA__LEY_27460 = 204019,
        PESCADOR_Y_PROCESADOR_ARTESANAL_INDEPENDIENTE = 204020,
        REG_ESPECIAL_D_LEG1057 = 204021,
        TRABAJADOR_DE_LA_MICROEMPRESA_AFILIADO_AL_SIS = 204022,
        CONDUCTOR_DE_LA_MICROEMPRESA_AFILIADO_AL_SIS = 204023,
        CONDUCTOR_DE_LA_MICROEMPRESA_SEGURO_REGULAR = 204024,
        FUNCIONARIO_PÚBLICO = 204025,
        EMPLEADO_DE_CONFIANZA = 204026,
        SERVIDOR_PÚBLICO_DIRECTIVO__SUPERIOR = 204027,
        SERVIDOR_PÚBLICO_EJECUTIVO = 204028,
        SERVIDOR_PÚBLICO_ESPECIALISTA = 204029,
        SERVIDOR_PÚBLICO_DE_APOYO = 204030,
        PERSONAL_DE_LA_ADMINISTRACIÓN_PÚBLICA_ASIGNACIÓN_ESPECIAL_DU_126_2001 = 204031,
        PERSONA_QUE_GENERA_INGRESOS_DE_CUARTA_QUINTA_CATEGORÍA = 204032
    }

    public enum EnumSITUACION_MOV_VENTA_COBRO
    {
        REGISTRADO = 205001,
        ANULADO = 205002
    }

    public enum EnumESTADO_CIVIL
    {
        SOLTERO = 207001,
        CASADO = 207002,
        VIUDO = 207003,
        DIVORCIADO = 207004,
        SEPARADO = 207005,
        CONVIVIENTE = 207006
    }

    //public enum EnumCATEGORIA_OCUPACIONAL
    //{
    //    OBRERO_BODEGA_____________________________________ = 210001,
    //    OBRERO_VIÑA_______________________________________ = 210002,
    //    JEFE_DE_LOGISTICA_________________________________ = 210003,
    //    AUXILIAR_DE_CONTABILIDAD__________________________ = 210004,
    //    ASISTENTE_DE_MARKETING____________________________ = 210005,
    //    JEFE_RRII__APODERADO____________________________ = 210006,
    //    CAJERA____________________________________________ = 210007,
    //    AUXCOMPCOBRANZAS________________________________ = 210008,
    //    ENCARGADO_CASA_ADMINISTRACION_____________________ = 210009,
    //    JEFE_PERSONAL_BODEGA______________________________ = 210010,
    //    GERENTE_GENERAL___________________________________ = 210011,
    //    AUXILIAR_DE_OFICINA_______________________________ = 210012,
    //    JEFE_CULTIVO_VIÑA_________________________________ = 210013,
    //    CARPINTERO________________________________________ = 210014,
    //    AUXILIAR_DE_EXPORTACION___________________________ = 210015,
    //    JEFE_LABORATORIO__________________________________ = 210016,
    //    GERENTE_COMERCIAL_________________________________ = 210017,
    //    ASISTENTE_DE_LABORATORIO__________________________ = 210018,
    //    AUXILIAR_DE_VENTAS________________________________ = 210019,
    //    CONTRALOR_________________________________________ = 210020,
    //    SECRETARIA_DE_GERENCIA____________________________ = 210021,
    //    JEFE_LABADJUNTO__________________________________ = 210022,
    //    SUBCONTADOR______________________________________ = 210023,
    //    JEFE_DE_MANTENIMIENTO_____________________________ = 210024,
    //    ENCADJADMVIÑA__________________________________ = 210025,
    //    CONTADOR__________________________________________ = 210026,
    //    JEFE_DE_SISTEMAS__________________________________ = 210027,
    //    DIRECTOR_TECNICO__ENOLOGO________________________ = 210028,
    //    PRACTICANTE_SENATI________________________________ = 210029,
    //    MAYORDOMO_CASA_HDA_______________________________ = 210030,
    //    GERENTE_DE_VENTAS_________________________________ = 210031,
    //    GUARDIAN_VIGILANTE________________________________ = 210032,
    //    ADJUNTA_ADMOFICINA_CALLAO________________________ = 210033,
    //    ADJUNTA_IMPULSOS_Y_PROMOCIONES____________________ = 210034,
    //    COORDINADORA_EVENTOS_Y_PROMOCI____________________ = 210035,
    //    ASISTENTA_SOCIAL__________________________________ = 210036,
    //    JEFE_DE_SEGURIDAD_________________________________ = 210037,
    //    GUIA_ATENCION_AL_CLIENTE__________________________ = 210038,
    //    JEFE_DE_ALMACEN___________________________________ = 210039,
    //    AYUDANTE_DE_ALMACEN_______________________________ = 210040,
    //    MANTCABALLERIZO__________________________________ = 210041,
    //    SUBGERENTE_DE_VIÑA_______________________________ = 210042,
    //    SUBGERENTE_DE_BODEGA_____________________________ = 210043,
    //    ASISTENTE_RRII___________________________________ = 210044,
    //    SUPERVVTAS_CANAL_AUTOSERVICIO____________________ = 210045,
    //    CHOFER____________________________________________ = 210046,
    //    JEFA_AREA_ATENCION_AL_CLIENTE_____________________ = 210047,
    //    ASISTENTE_OFICINA_________________________________ = 210048,
    //    OBRCASA_ADMINIST_________________________________ = 210049,
    //    OBRERO_DE_MANTENIMIENTO___________________________ = 210050,
    //    ASISTENTE_DE_SISTEMAS_____________________________ = 210051,
    //    PRACTICANTE_PREPROFESIONAL________________________ = 210052,
    //    ENCARGADO_CAJA_ICA________________________________ = 210053,
    //    SUPERVISOR_DE_SEGURIDAD___________________________ = 210054,
    //    JEFE_DE_VIÑA______________________________________ = 210055,
    //    ASISTENTE_MANTENIMIENTO___________________________ = 210056,
    //    AUXILIAR_DE_COMPRAS_______________________________ = 210057,
    //    GERENTE_DE_DESARROLLO_ESTRATEGICO_________________ = 210058,
    //    AGENTE_LIMPIEZA___________________________________ = 210059,
    //    SUPERVISOR_DE_CAMPO_______________________________ = 210060,
    //    CONTADOR_GENERAL__________________________________ = 210061,
    //    JEFE_DE_PLANEAMIENTO_DE_GESTION_Y_CONTROL_________ = 210062,
    //    COORDINADORA_CANAL_HORECA_________________________ = 210063,
    //    COORDINADORA_CANAL_MODERNO_AUTOSERVICIO___________ = 210064,
    //    COORDINADORA_CANAL_TRADICIONAL____________________ = 210065,
    //    ASESORA_COMERCIAL_________________________________ = 210066,
    //    COORDINADORA_COMERCIAL____________________________ = 210067,
    //    ASESOR_COMERCIAL__________________________________ = 210068,
    //    JEFA_DE_CASA_HACIENDA_____________________________ = 210069,
    //    EMPLEADO_LIMPIEZA_________________________________ = 210070,
    //    GERENTE_DE_ADMINISTRACION_________________________ = 210071,
    //    ASISTENTE_DE_PRODUCCION_VIÑA______________________ = 210072,
    //    ASISTENTE_DE_ALMACEN______________________________ = 210073,
    //    ASISTENTE_DE_LOGISTICA____________________________ = 210074,
    //    MANTENIMIENTO_Y_LIMPIEZA_ATENCIÓN_AL_CLIENTE______ = 210075,
    //    CAJERA_Y_CONTROL_DE_MERCADERIA____________________ = 210076,
    //    ASISTENTE_ADMINISTRATIVO__________________________ = 210077,
    //    SUPERVISORA_DE_MERCADERISTAS______________________ = 210078,
    //    DIRECTOR_DE_MARKETING_____________________________ = 210079,
    //    MERCADERISTA______________________________________ = 210080,
    //    PROMOTORA_DE_VENTAS_______________________________ = 210081,
    //    PROMOTOR_DE_VENTAS________________________________ = 210082,
    //    ASISTENTE_DE_COORDINADORA_CANAL_MODERNO___________ = 210083,
    //    VENDEDOR_SUR______________________________________ = 210084,
    //    VENDEDORA_NORTE___________________________________ = 210085,
    //    SUPERVISOR_DE_DISTRIBUCIÓN________________________ = 210086,
    //    VIGILANTE_________________________________________ = 210087,
    //    SOMMELIER_________________________________________ = 210088,
    //    ASISTENTE_DE_CONTABILIDAD_________________________ = 210089,
    //    SECRETARIA_RECEPCIONISTA__________________________ = 210090,
    //    AUXILIAR_GLOBAL_GAP____________________________ = 210091,
    //    ANALISTA_DE_COMPRAS_______________________________ = 210092,
    //    ENCARGADA_DE_LAS_BUENAS_PRACTICAS_AGRICOLAS_______ = 210093,
    //    TESORERA__________________________________________ = 210094,
    //    VENDEDORA_AUTOSERVICIOS___________________________ = 210095,
    //    VENDEDOR_DISTRIBUIDORES___________________________ = 210096,
    //    VENDEDORA_DISTRIBUIDORES__________________________ = 210097,
    //    AMA_DE_LLAVES_____________________________________ = 210098,
    //    VENDEDOR__________________________________________ = 210099,
    //    JEFE_DE_MARKETING_________________________________ = 210100,
    //    VENDEDORA_________________________________________ = 210101,
    //    ENCARGADA_DE_SISTEMAS_INTEGRADOS_DE_GESTIÓN_______ = 210102,
    //    ASISTENTE_DE_EXPORTACIONES________________________ = 210103,
    //    IMPULSADORA_EN_TIENDA_____________________________ = 210104,
    //    CONSERJE__________________________________________ = 210105,
    //    ASISTENTE_DE_CREDITOS_Y_COBRANZAS_________________ = 210106,
    //    ESTIBADOR_________________________________________ = 210107,
    //    ASISTENTE_DE_PRODUCCIÓN___________________________ = 210108,
    //    ASISTENTE_DE_TESORERIA____________________________ = 210109,
    //    JEFE_DE_CONTROL_DE_PRESUPUESTO____________________ = 210110,
    //    ENCARGADA_DEL_SISTEMA_HACCP_______________________ = 210111,
    //    ASISTENTE_DE_SISTEMAS_INTEGRADOS_DE_GESTIÓN_______ = 210112,
    //    JEFE_DE_CREDITOS_Y_COBRANZAS______________________ = 210113,
    //    OBRERO_DE_PRODUCCIÓN = 210114,
    //    SUPERVISOR_DE_PRODUCCION = 210115,
    //    OBRERO_DE_SEGURIDAD_PATRIMONIAL = 210116,
    //    ASISTENTE_COMERCIAL = 210117,
    //    ADMINISTRADOR = 210118,
    //    AUXILIAR_DE_ALMACEN = 210119,
    //    EJECUTIVO_DE_IMPORTACIONES = 210120,
    //    SUPERVISOR_CONTABLE = 210121,
    //    REPRESENTANTE_TECNICO_COMERCIAL = 210122,
    //    GERENTE_DE_MARKETING = 210123,
    //    GERENTE_DE_LOGISTICA = 210124,
    //    OPERARIO = 210125,
    //    AUXILIAR_DE_RECURSOS_HUMANOS = 210126,
    //    REPRESENTANTE_TECNICO_COMERCIAL = 210127,
    //    SUPERVISOR_DE_VTA_DE_MAIZ = 210128,
    //    ANALISTA_DE_CREDITOS__Y_COBRANZA = 210129
    //}

    public enum EnumNIVEL_EDUCATIVO
    {
        SIN_EDUCACIÓN_FORMAL = 211001,
        EDUCACIÓN_ESPECIAL_INCOMPLETA = 211002,
        EDUCACIÓN_ESPECIAL_COMPLETA = 211003,
        EDUCACIÓN_PRIMARIA_INCOMPLETA = 211004,
        EDUCACIÓN_PRIMARIA_COMPLETA = 211005,
        EDUCACIÓN_SECUNDARIA_INCOMPLETA = 211006,
        EDUCACIÓN_SECUNDARIA_COMPLETA = 211007,
        EDUCACIÓN_TÉCNICA_INCOMPLETA = 211008,
        EDUCACIÓN_TÉCNICA_COMPLETA = 211009,
        EDUCACIÓN_SUPERIOR_INSTITUTO_SUPERIOR_ETC_INCOMPLETA_ = 211010,
        EDUCACIÓN_SUPERIOR_INSTITUTO_SUPERIOR_ETC_COMPLETA_ = 211011,
        EDUCACIÓN_UNIVERSITARIA_INCOMPLETA = 211012,
        EDUCACIÓN_UNIVERSITARIA_COMPLETA = 211013,
        GRADO_DE_BACHILLER = 211014,
        TITULADO = 211015,
        ESTUDIOS_DE_MAESTRÍA_INCOMPLETA = 211016,
        ESTUDIOS_DE_MAESTRÍA_COMPLETA = 211017,
        GRADO_DE_MAESTRÍA = 211018,
        ESTUDIOS_DE_DOCTORADO_INCOMPLETO = 211019,
        ESTUDIOS_DE_DOCTORADO_COMPLETO = 211020,
        GRADO_DE_DOCTOR = 211021
    }

    public enum EnumPAGO
    {
        EFECTIVO = 212001,
        DEPÓSITO_EN_CUENTA = 212002,
        GIRO = 212004,
        CHEQUE = 212005
    }

    public enum EnumREGIMEN_PENSIONARIO
    {
        CAJA_DE_PENSIONES_MILITAR = 213001,
        CAJA_DE_PENSIONES_POLICIAL = 213002,
        OTROS_REGIMENES_PENSIONARIOS = 213003,
        ONP_19990 = 213004,
        SPP_INTEGRA = 213005,
        SPP_HORIZONTE = 213006,
        SPP_PROFUTURO = 213007,
        SPP_PRIMA = 213008,
        DECRETO_LEY_20530_SISTEMA_NACIONAL_DE_PENSIONES = 213009,
        CAJA_DE_BENEFICIOS_DE_SEGURIDAD_SOCIAL_DEL_PESCADOR = 213010,
        SIN_REGIMEN_PENSIONARIO = 213011,
        SPP_INTEGRA_MIXTA = 213012,
        SPP_HORIZONTE_MIXTA = 213013,
        SPP_PROFUTURO_MIXTA = 213014,
        SPP_PRIMA_MIXTA = 213015,
        SPP_HABITAT = 213016,
        SPP_HABITAT_MIXTA = 213017
    }

    public enum EnumSEXO
    {
        MASCULINO = 214001,
        FEMENINO = 214002
    }

    public enum EnumAPORTE_ARTISTA
    {
        CTS, VACACIONES, GRATIFICACIONES = 215001,
        SOLO_GRATIFICACIONES = 215002
    }

    public enum EnumVIDA_SEGURO_ACCIDENTES
    {
        SCTR_SALUD = 216001,
        CONVENIO_IES = 216002
    }

    public enum EnumREGIMEN_LABORAL
    {
        REGIMEN_REGULAR = 217001,
        PÚBLICO_GENERAL_DECRETO_LEGISLATIVO_N_276 = 217002,
        PROFESORADO_LEY_N_24029 = 217003,
        MAGISTERIO_LEY_N_29062 = 217004,
        DOCENTES_UNIVERSITARIOS_LEY_N_23733 = 217005,
        PROFESIONALES_DE_LA_SALUD_LEY_N_23536 = 217006,
        TECNICOS_Y_AUXILIARES_ASIST_DE_LA_SALUD_LEY_N_28561 = 217007,
        SERUM_LEY_N_23330 = 217008,
        JUECES_CARRERA_JUDICIAL_LEY_N_29277 = 217009,
        FISCALES_D_LEG__N_052 = 217010,
        SERVICIO_DIPLOMÁTICO_DE_LA_REPÚBLICA_LEY_N_28091 = 217011,
        MILITARES = 217012,
        POLICIA_NACIONAL_DEL_PERÚ_LEY_N_27238 = 217013,
        MICROEMPRESA_D_LEG_1086 = 217016,
        PEQUEÑA_EMPRESA_D_LEG_1086 = 217017,
        REGIMEN_AGRARIO = 217018,
        EXPORTACION_NO_TRADICIONAL_D_LEY_22342 = 217019,
        MINEROS = 217020,
        CONSTRUCCION_CIVIL = 217021,
        OTROS_NO_PREVISTOS = 217022
    }

    public enum EnumSITUACION_ESPECIAL
    {
        NINGUNA = 218001,
        TRABAJADOR_DE_DIRECCIÓN = 218002,
        TRABAJADOR_DE_CONFIANZA = 218003,
    }

    public enum EnumCONVENIO_TRIBUTARIO
    {
        NINGUNO = 219001,
        CANADA = 219002,
        CHILE = 219003,
        CAN_ = 219004,
        BRASIL = 219005
    }

    public enum EnumPERIODICIDAD
    {
        MENSUAL = 220001,
        QUINCENAL = 220002,
        SEMANAL = 220003,
        DIARIA = 220004,
        OTROS = 220005
    }

    public enum EnumREGIMEN_SALUD
    {
        ESSALUD_REGULAR_ = 221001,
        ESSALUD_REGULAR_Y_EPS_SERV_PROP = 221002,
        ESSALUD_TRAB_PESQUEROS = 221003,
        ESSALUD_TRAB_PESQ_Y_EPS_SERVPROP = 221004,
        ESSALUD_AGRARIO_ACUÍCOLA = 221005,
        ESSALUD_PENSIONISTAS = 221006,
        SANIDAD_FFAA_Y_POLICIALES_1 = 221007,
    }

    public enum EnumMOTIVO_CESE
    {
        RENUNCIA = 222001,
        RENUNCIA_CON_INCENTIVOS = 222002,
        DESPIDO_O_DESTITUCIÓN = 222003,
        CESE_COLECTIVO = 222004,
        JUBILACIÓN = 222005,
        INVALIDEZ_ABSOLUTA_PERMANENTE = 222006,
        TERMINACIÓN_DE_LA_OBRA_O_SERVICIO_O_VENCIMIENTO_DEL_PLAZO = 222007,
        MUTUO_DISENSO = 222008,
        FALLECIMIENTO = 222009,
        SUSPENSIÓN_DE_LA_PENSIÓN = 222010,
        REASIGNACIÓN_SERVIDOR_DE_LA_ADMINISTRACIÓN_PÚBLICA = 222011
    }

    public enum EnumSITUACION_TRABAJADOR
    {
        ACTIVO_O_SUBSIDIADO_11 = 223001,
        BAJA_13 = 223002,
        SUSPENSIÓN_PERFECTA_DE_LABORES_15 = 223003,
        SIN_VINC_LAB_CON_CONC_PEND_POR_LIQUIDAR_19 = 223004
    }

    public enum EnumMODALIDAD_FORMATIVA
    {
        APRENDIZAJE_CON_PREDOMINIO_EN_LA_EMPRESA = 224001,
        PRÁCTICAS_PRE_PROFESIONALES = 224002,
        PRÁCTICAS_PROFESIONALES = 224003,
        CAPACITACIÓN_LABORAL_JUVENIL = 224004,
        PASANTÍA_EN_LA_EMPRESA = 224005,
        DOCENTE_Y_O_CATEDRÁTICO_CON_CONVENIO_DE_PASANTÍA_ = 224006,
        REINSERCIÓN_LABORAL = 224007
    }

    public enum EnumSCTR_SALUD
    {
        EPS = 225001,
        ESSALUD = 225002
    }

    public enum EnumSCTR_PENSION
    {
        ONP = 226001,
        SEGURO_PRIVADO = 226002
    }

    public enum EnumCONTRATO
    {
        A_PLAZO_INDETERMINADO = 227001,
        A_TIEMPO_PARCIAL = 227002,
        POR_INICIO_O_INCREMENTO_DE_ACTIVIDAD = 227003,
        POR_NECESIDADES_DEL_MERCADO = 227004,
        POR_RECONVERSIÓN_EMPRESARIAL = 227005,
        OCASIONAL = 227006,
        DE_SUPLENCIA = 227007,
        DE_EMERGENCIA = 227008,
        PARA_OBRA_DETERMINADA_O_SERVICIO_ESPECÍFICO = 227009,
        INTERMITENTE = 227010,
        DE_TEMPORADA = 227011,
        DE_EXPORTACIÓN_NO_TRADICIONAL = 227012,
        DE_EXTRANJERO = 227013,
        ADMINISTRATIVO_DE_SERVICIOS = 227014,
        OTROS = 227015
    }

    public enum EnumTIPO_CUENTA
    {
        ACTIVO = 228001,
        PASIVO = 228002,
        RESULTADO = 228003,
        NATURALEZA = 228004,
        ORDEN = 228005
    }

    public enum EnumTIPO_DE_NATURALEZA
    {
        DEBE = 229001,
        HABER = 229002
    }

    public enum EnumTIPO_DE_SELECCION
    {
        SOLO_SELECCIONADOS = 230001,
        NO_SELECCIONADOS = 230002,
        TODOS = 230003
    }

    public enum EnumSITUACION_PLANO_DE_PRODUCCION
    {
        PENDIENTE = 231001,
        EN_PROCESO = 231002,
        TERMINADO = 231003
    }

    public enum EnumTIPO_CUENTA_BANCARIA
    {
        CTACTE_SOLES = 232001,
        CTACTE_DOLARES = 232002,
        CTS_SOLES = 232003,
        AHORRO_SOLES = 232004,
        AHORRO_DOLARES = 232005,
        CTADETRACCION_SOLES = 232006
    }

    public enum EnumTIPO_GENERACIÓN_BOLETA
    {
        MANUAL = 233001,
        AUTOMÁTICO = 233002
    }

    public enum EnumTIPO_CALCULO_BOLETA_
    {
        MONTO = 234001,
        PORCENTAJE = 234002
    }

    public enum EnumTIPO_RESUMEN_PLANILLA
    {
        MENSUAL = 235001,
        QUINCENAL = 235002,
        SEMANAL = 235003
    }

    public enum EnumTIPO_MARCACION_MASIVA
    {
        INGRESO = 236001,
        INICIO_REFRIGERIO = 236002,
        FIN_REFRIGERIO = 236003,
        SALIDA = 236004
    }

    public enum EnumCARACTERISTICA_INSUMO
    {
        PIEL_1 = 237001,
        PIEL_2 = 237002,
        PIEL_3 = 237003,
        PIEL_4 = 237004,
        PIEL_5 = 237005,
        FORRO_1 = 237007,
        FORRO_2 = 237008,
        PLANTILLA__480__9 = 237009,
        PLANT__468_9 = 237010,
        HILO_1 = 237011,
        HILO_2 = 237012,
        PLANT2561 = 237013,
        PLANT468PLANTA = 237014,
        PLANT_579__9 = 237015,
        PLANT_6463__9 = 237016,
        PLANT_2511__9 = 237017,
        PLANT_0534__9_ESPEC = 237018,
        PLANT_0534__9 = 237019,
        PLANT_0864__9 = 237020,
        PLANT602__9 = 237021,
        PLANT_652__9 = 237022,
        PUNTERA_2 = 237023,
        PLANT_2569__9 = 237024,
        PUNTERA_1 = 237025,
        PUNT_2569_ESPEC = 237026,
        PLANT_2566__9 = 237027,
        PLANT_555__9 = 237028,
        PLANT_600__9 = 237029,
        PLANT_2566__9_ESPEC = 237030,
        PLANT_216__9 = 237031,
        PLANT_559__9 = 237032,
        PLANT_3402__9 = 237033,
        PLANT556 = 237034,
        PLANT_483 = 237035,
        PLANT_652_PLANTA = 237036,
        PLANT_2560 = 237037,
        PLANT_2566 = 237038,
        PLANT_597__9 = 237039,
        PLANT_485 = 237040,
        PLANT595__9 = 237041,
        PLANT_578 = 237042,
        PLANT469__9 = 237043,
        PLANT_864__9 = 237044,
        PUNTERA_6 = 237045,
        PLANT_559__10 = 237046,
        PLANT_3589__9 = 237047,
        PLANT_3574__9 = 237048,
        PLANT_616__9 = 237049,
        PLANT_480__9 = 237050,
        PLANT_029__9 = 237051,
        PLANT_0556__9 = 237052,
        PLANT_571 = 237053,
        PLANT_614 = 237054,
        PLANT_598 = 237055,
        PLANT_0534__7 = 237056,
        PIEL_6 = 237057,
        PLANT_3402__7 = 237058,
        PLANT_2569__7 = 237059,
        PLANT_2566__1 = 237060,
        PLANT_2566__7 = 237061,
        PLANT_156 = 237062
    }

    public enum EnumTIPO_CRÉDITO
    {
        PRÉSTAMO = 238001,
        ADELANTO_DE_SUELDO = 238002
    }

    public enum EnumSITUACION
    {
        REGISTRADO = 240001,
        ANULADO = 240002,
        PENDIENTE = 240003
    }

    public enum EnumTIPO_RETENCION
    {
        REGULAR = 241001,
        EXTERNOS = 241002
    }

    public enum EnumTIPO_DEVOLUCION_SALIDA
    {
        POR_RECHAZO = 242001,
        POR_SOBRANTE = 242002,
        FALLADO = 242003
    }

    public enum EnumCONDICIONES_DE_COMPRAS
    {
        CONTRA_ENTREGA_PAGO_AL_100 = 243001,
        CONTRA_ENTREGA_PAGO_ANTICIPADO_50 = 243002,
        ANTICIPO_20_Y_80_CONTRA_ENTREGA = 243003,
        LETRAS_A_90_DIAS = 243004,
        LETRAS_A_60_DIAS = 243005,
        LETRAS_30_60_90_120_DIAS = 243006,
        FACTURA_A_30_DIAS = 243007,
        FACTURA_A_15_DIAS = 243008,
        FACTURA_A_45_DIAS = 243009,
        ANTICIPO_50_Y_50_CONTRA_ENTREGA = 243010,
        ANTICIPO_30_Y_70_CONTRA_ENTREGA = 243011,
        LETRAS_30_Y_60_DIAS = 243012,
        FACTURA_7_DIAS = 243013,
        LETRAS_A_120_DIAS = 243014,
        LETRAS_A_45_DIAS = 243015,
        FACTURA_30_60_90_DIAS = 243016,
        FACTURA_A_60_DIAS = 243017,
        ANTICIPADO_30_SALDO_LETRA_45_DIAS = 243018,
        CARTA_DE_CREDITO_VENCIMIENTO_30_DIAS = 243019,
        ANTICIPADO_60_Y_40_CONTRAENTREGA = 243020,
        LETRAS_A_30_DIAS = 243021,
        PAGO_ANTICIPADO = 243022,
        CARTA_DE_CREDITO_VENCIMIENTO_45_DIAS = 243023,
        ANTICIPADO_40_Y_60_CONTRAENTREGA = 243024,
        PAGO_ANTICIPADO_70_Y_30_CONTRAENTREGA = 243025,
        PAGO_ANTICIPADO_30_Y_70_CONTRETREGA = 243026,
        LETRA_30_60_Y_90_DIAS = 243027,
        FACTURA_A_180_DIAS = 243028,
        LETRA_A_180_DIAS = 243029,
        ANTICIPO_50_Y_50_A_15_DIAS = 243030,
        Letras_60_y_90_dias = 243031,
        Letra_a_45_y_90_dias = 243032,
        LETRAS_A_180_210_Y_240_DIAS = 243033,
        LETRA_A_150_DIAS = 243034,
        Letra_a_60_75_90_y_120_días = 243035,
        ANTICIPO_50_Y_50_A_30_DIAS = 243036,
        PAGO_30_CONTADO = 243037,
        ANTICIPO_30_SALDO_A_30_DIAS_FE = 243038,
        TRANSFERENCIA_BANCARIA = 243039,
        ANTICIPO_40_40_Y_20_CONTRA_ENTREGA = 243040,
        FACTURA_A_10_DIAS = 243041,
        ANTICIPO_45_35_Y_20_CONTRA_ENTREGA = 243042,
        CANJE_PUBLICITARIO = 243043,
        ANT30_35_30_DIAS_REC_EMB_35_A_60_DIAS = 243044,
        LETRAS_A_150_180_Y_210_DIAS = 243045,
        LETRAS_30_45_Y_60_DIAS = 243046,
        LETRA_A_90_120_Y_150_DIAS = 243047,
        FACTURA_A_90_DIAS = 243048,
        CONTADO = 243049,
        CREDITO_POR_ACTUALIZAR = 243050,
        FACTURA_A_120_DIAS = 243051,
        LETRA_A_101_131_Y_162_DIAS = 243052,
        TRANSFERENCIA_GRATUITA = 243053,
        ANTICIPO_50_Y_50_FACTURABLE_A_15_DÍAS = 243055,
        ANTICIPO_50_Y_CREDITO_60_DIAS = 243056,
        FACTURA_NEGOCIABLE_30_DIAS = 243057,
        FACTURA_NEGOCIABLE_60_DIAS = 243058,
        FACTURA_NEGOCIABLE_90_DIAS = 243059,
        FACTORING_60_DIAS = 243060,
        FACTORING_90_DIAS = 243061,
        FACTURA_NEGOCIABLE_45_DÍAS = 243062,
        FACTURA_NEGOCIABLE_120_DIAS = 243064,
        FACTORING_120_DIAS = 243065,
        CARTA_DE_CREDITO = 243067,
        CRÉDITO_75_DÍAS = 243068,
        ANTICIPO_30_Y_RESTANTE_CRÉDITO_60_DÍAS = 243069,
        ANTICIPO_50_Y_RESTANTE_LETRA_45_DÍAS = 243072
    }

    public enum EnumSITUACION_MOVCHEQUE
    {
        EMITIDO = 244001,
        ENTREGADO = 244002,
        ANULADO = 244003
    }

    public enum EnumTIPO_EGRESO_TESORERIA
    {
        PAGO_PROVEEDORES = 245001,
        ENTREGA_A_RENDIR = 245002,
        CAJA_CHICA = 245003,
        PAGO_PERSONAL = 245004,
        PAGOS_VARIOS = 245005
    }

    public enum EnumTIPO_DOCUMENTO_TESORERIA
    {
        EFECTIVO = 246001,
        CHEQUE = 246002,
        TRANSFERENCIA = 246003,
        CANJE_DOCUMENTOS = 246004
    }

    public enum EnumSITUACION_CAJA_CHICA
    {
        PENDIENTE = 247001,
        ABIERTO = 247002,
        CERRADO = 247003,
        LIQUIDADO = 247004
    }

    public enum EnumTIPO_EGRESO_CAJA_CHICA_
    {
        GASTO = 248001,
        SALIDA_PROVISIONAL = 248002
    }

    public enum EnumSITUACION_LIQUIDACION
    {
        PENDIENTE = 249001,
        PROVISIONADO = 249002,
        ANULADO = 249003
    }

    public enum EnumSITUACION_MOVIMIENTO_BANCARIO
    {
        REGISTRADO = 250001,
        CONCILIADO = 250002,
        ANULADO = 250003
    }

    public enum EnumSITUACION_MOV_ASIGNA_DOCUMENTO
    {
        REGISTRADO = 251001,
        ANULADO = 251002
    }

    public enum EnumTIPO_NATURALEZA_COMPRA
    {
        REGULAR = 252001,
        HECHURA = 252002
    }

    public enum EnumTIPO_CONFIGURACION_CONTABLE
    {
        VENTAS_COMERCIALES = 253001,
        COMPRAS = 253002
    }

    public enum EnumTIPO_BENEFICIO
    {
        SUELDO = 254001,
        GRATIFICACION = 254002,
        CTS = 254003,
        UTILIDADES = 254004,
        VACACIONES = 254005
    }

    public enum EnumTIPO_ORIGEN_EMISION
    {
        PREIMPRESO = 255001,
        TICKETERA = 255002
    }

    public enum EnumTIPO_SALIDA_CAJAVENTA
    {
        SALIDA_POR_DEPOSITO = 256001,
        SALIDA_POR_EMERGENCIA = 256002,
        SALIDA_POR_NOTA_CREDITO = 256003
    }

    public enum EnumTIPO_PLANILLA
    {
        CTS = 257001,
        GRATIFICACION = 257002,
        VACACIONES = 257003,
        Utilidades = 257004,
        Sueldo = 257005
    }

    public enum EnumLIBRO_CONTABLE
    {
        VENTAS = 258001,
        COMPRAS = 258002,
        CAJAVENTA = 258003
    }

    public enum EnumDESCUENTO_POR_APERTURA
    {
        LIQUIDACION = 259001,
        ESPECIAL = 259002,
        OTROS = 259003,
        APERTURA = 259004
    }

    public enum EnumAGRUPACION_PARTABLA
    {
        FACTURACION_CAJA_VENTA = 260001,
        FORMA_PAGO_CAJA_VENTA = 260002,
        COMPROBANTES_CAJA_CHICA = 260003,
        FORMA_PAGO_VALE = 260004
    }

    public enum EnumDIVISION
    {
        VIVEROS = 261001,
        HORTALIZAS = 261002,
        MAIZ = 261003
    }

    public enum EnumSITUACION_VALE_EMISION
    {
        PENDIENTE = 262001,
        FACTURADO = 262002,
        ANULADO = 262003,
        CERRADO = 262004,
        PROCESADO = 262005,
        PAGADO_POR_CLIENTE = 262006
    }

    public enum EnumTIPO_ORIGEN_GUIA
    {
        REGULARES = 264001,
        MASIVOS = 264002,
        SERVICIOS = 264003
    }

    public enum EnumTIPO_SERVICIO
    {
        TRANSPORTE = 265001,
        COMISIONES = 265002,
        OTROS = 265003,
        VALES_EMISION = 265004
    }

    public enum EnumSITUACION_ARTICULOS_DE_VALE_EMSION
    {
        PENDIENTE = 266001,
        ATENDIDO = 266002,
        ANULADO = 266003
    }

    public enum EnumTIPO_MOVIMIENTO_BENEFICIO
    {
        ASIGNADO = 267001,
        DESASIGNADO = 267002
    }

    public enum EnumTIPO_RENTA
    {
        IMPUESTO_A_LA_RENTA = 268001
    }

    public enum EnumSITUACION_PRESTAMO_CLIENTE
    {
        PENDIENTE = 269001,
        ATENDIDO = 269002,
        DEVUELTO = 269003
    }

    public enum EnumTIPOS_DE_DIARIO
    {
        DIARIO_CONTABLE = 270001,
        DIARIO_DE_AJUSTE = 270002,
        DIARIO_DE_CIERRE = 270003
    }

    public enum EnumCLASE_FILE
    {
        IMPORTACIONES = 271001,
        NACIONAL = 271002,
        NINGUNO = 271003
    }

    public enum EnumTIPO_DE_DETRACCION
    {
        N = 272001,
        L = 272002,
        V = 272003
    }

    public enum EnumTIPOS_DE_CONCEPTOS_PARA_COMPRA_Y_VENTAS
    {
        BASE_IMPONIBLES = 273001,
        IMPUESTO_GENERAL__A_LAS_VENTAS = 273002,
        IMPUESTO_SELECTIVO_AL_CONSUMO = 273003,
        OTROS_IMPUESTO = 273004,
        TOTAL_GENERAL = 273005,
        IMPUESTO_EXTRAORDINARIO_DE_SOLIDARIDAD = 273006,
        IMPUESTO_A_LA_RENTA = 273007
    }

    public enum EnumTIPO_DE_AJUSTES_DE_DIFERENCIA
    {
        POR_CUENTA__CODIGO_AUXILIAR = 274001,
        POR_CUENTA__CODIGO_AUXILIAR__DOCUMENTO = 274002,
        POR_SALDO_DE_CUENTA = 274003
    }

    public enum EnumTIPO_DE_BALANCE_CONTABLE
    {
        ACTIVO_PASIVO_PATRIMONIO = 275001,
        CUENTAS_DE_ORDEN = 275002,
        INGRESOS_GASTOS = 275003,
        CUENTAS_DE_CIERRE = 275004,
        AMBOS_ESTADOS_FINANCIEROS = 275005,
        ESTADOS_FINANCIEROS_POR_FUNCION = 275006,
        ESTADOS_FINANCIEROS_POR_NATURALEZA = 275007
    }

    public enum EnumTIPO_BASE_IMPONIBLES
    {
        BASE = 276001,
        BASE_I = 276002,
        BASE_GNG = 276003,
        BASE_SD = 276004,
        BASE_EXPO = 276006,
        BASE_EXO = 276007
    }

    public enum EnumTIPO_IGV
    {
        IGV = 277001,
        IGV_GNG = 277002,
        IGV_SD = 277003
    }

    public enum EnumTIPO_TOTAL
    {
        TOTAL = 278001
    }

    public enum EnumTIPO_DEPRECIACION
    {
        LINEAL = 280001,
        UNIDADES_PRODUCIDAS = 280002,
        OTROS = 280003
    }

    public enum EnumCONDICION_LOCAL
    {
        PROPIO = 281001,
        ALQUILADO = 281002
    }

    public enum EnumTIPO_CONTRIBUYENTE
    {
        PERSONA_NATURAL_SIN_NEGOCIO = 282001,
        PERSONA_NATURAL_CON_NEGOCIO = 282002,
        SOCIEDAD_CONYUGAL_SIN_NEGOCIO = 282003,
        SOCIEDAD_CONYUGAL_CON_NEGOCIO = 282004,
        SUCESION_INDIVISA_SIN_NEGOCIO = 282005,
        SUCESION_INDIVISA_CON_NEGOCIO = 282006,
        EMPRESA_INDIVIDUAL_DE_RESP_LTDA = 282007,
        SOCIEDAD_CIVIL = 282008,
        SOCIEDAD_IRREGULAR = 282009,
        ASOCIACION_EN_PARTICIPACION = 282010,
        ASOCIACION = 282011,
        FUNDACION = 282012,
        SOCIEDAD_EN_COMANDITA_SIMPLE = 282013,
        SOCIEDAD_COLECTIVA = 282014,
        INSTITUCIONES_PUBLICAS = 282015,
        INSTITUCIONES_RELIGIOSAS = 282016,
        SOCIEDAD_DE_BENEFICIENCIA = 282017,
        ENTIDADES_DE_AUXILIO_MUTUO = 282018,
        UNIVERS_CENTROS_EDUCAT_Y_CULT = 282019,
        GOBIERNO_REGIONAL_LOCAL = 282020,
        GOBIERNO_CENTRAL = 282021,
        COMUNIDAD_LABORAL = 282022,
        COMUNIDAD_CAMPESINA, NATIVA, COMUNAL = 282023,
        COOPERATIVAS_SAIS_CAPS = 282024,
        EMPRESA_DE_PROPIEDAD_SOCIAL = 282025,
        SOCIEDAD_ANONIMA = 282026,
        SOCIEDAD_EN_COMANDITA_POR_ACCIONES = 282027,
        SOCCOMRESPONS_LTDA = 282028,
        SUC, AGEMPEXTRANJ, ESTPERM_NO_DOM = 282029,
        EMPRESA_DE_DERECHO_PUBLICO = 282030,
        EMPRESA_ESTATAL_DE_DERECHO_PRIVADO = 282031,
        EMPRESA_DE_ECONOMIA_MIXTA = 282032,
        ACCIONARIADO_DEL_ESTADO = 282033,
        MISIONES_DIPLOMATICAS_Y_ORG_INTER = 282034,
        JUNTA_DE_PROPIETARIOS = 282035,
        OFREPRESENTACION_DE_NO_DOMICILIADO = 282036,
        FONDOS_MUTUOS_DE_INVERSION = 282037,
        SOCIEDAD_ANONIMA_ABIERTA = 282038,
        SOCIEDAD_ANONIMA_CERRADA = 282039,
        CONTRATOS_COLABORACION_EMPRESARIAL = 282040,
        ENTINSTCOOPERACTECNICA__ENIEX = 282041,
        COMUNIDAD_DE_BIENES = 282042,
        SOCIEDAD_MINERA_DE_RESPLIMITADA = 282043,
        ASOC_FUNDAC_Y_COMITE_NO_INSCRITOS = 282044,
        PARTIDOS, MOVIM_ALIANZAS_POLITICAS = 282045,
        ASOC_DE_HECHO_DE_PROFESIONALES = 282046,
        CAFAES_Y_SUBCAFAES = 282047,
        SINDICATOS_Y_FEDERACIONES = 282048,
        COLEGIOS_PROFESIONALES = 282049,
        COMITES_INSCRITOS = 282050,
        ORGANIZACIONES_SOCIALES_DE_BASE = 282051
    }

    public enum EnumTIPO_PROVEEDOR
    {
        MERCADERIA = 283001,
        MANTENIMIENTO = 283002,
        REPUESTOS_Y_MAQUINARIAS = 283004,
        SERVICIOS = 283005,
        OTROS = 283006,
        OPERADOR_LOGISTICO = 283007,
        TERCERO = 283008
    }

    public enum EnumTIPO_REGIMEN_EMPRESARIAL
    {
        PRIVADO = 284001,
        PUBLICO = 284002
    }

    public enum EnumCATEGORIA_EMPRESAS
    {
        GRANDES_EMPRESAS = 285001,
        EMPRESAS_MEDIANAS = 285002,
        PEQUEÑAS_EMPRESAS = 285003,
        MICRO_EMPRESA = 285004
    }

    public enum EnumTIPO_CAJA_CHICA
    {
        REMUNERACIONES = 288001,
        VIATICOS_Y_MOVILIDAD = 288002,
        INSUMOS = 288003,
        COSTOS_OPERACIONALES = 288004
    }

    public enum EnumPARAMETROS_DE_CUENTAS
    {
        GANANCIA = 289001,
        PERDIDA = 289002,
        COSTO = 289003,
        COMPRA_S = 289004,
        COMPRA_D = 289005,
        VENTA_S = 289006,
        VENTA_D = 289007,
        CC_PARA_GASTOS_FINANCIEROS = 289008
    }

    public enum EnumTIPO_DE_CALIBRE
    {
        LARGE = 290001,
        MEDIUM = 290002,
        EXTRA_LARGE = 290003,
        JUMBO = 290004
    }

    public enum EnumTIPO_DE_CATEGORIA_DE_ARTICULO
    {
        CAT_1 = 292001,
        FSM = 292002
    }

    public enum EnumTIPO_COLOR_UVA
    {
        OSCURA = 293001,
        CLARO = 293002
    }

    public enum EnumTIPO_DE_COMPRA_EXPORTACION
    {
        MG = 294001,
        PRECIO_FIJO = 294002,
        CO = 294003
    }

    public enum EnumINCOTERMS
    {
        FOB = 295001,
        EXW = 295002,
        CIF = 295003,
        DDU = 295004,
        FCA = 295005,
        CPT = 295006,
        CIP = 295007,
        DAP = 295008,
        DPU = 295009,
        DDP = 295010,
        FAS = 295011,
        CFR = 295012
    }

    public enum EnumBL_EMISION
    {
        SEA_WILL_BILL = 296001,
        EN_ORIGEN = 296002,
        EN_DESTINO = 296003
    }

    public enum EnumTIPO_DE_FLETE
    {
        COLLECT = 299001,
        PRE_PAID = 299002
    }

    public enum EnumDOCUMENTO_DE_EXPORTACION
    {
        BILL_OF_LADING = 300001,
        CERTIFICADO_FITOSANITARIO = 300002,
        COLD_TREATMENT = 300003,
        FACTURA_COMERCIAL = 300004,
        PACKING_LIST = 300005,
        CERTIFICADO_DE_ORIGEN = 300006,
        ORDEN_DE_COMPRA_CLIENTE = 300007,
        FORMULARIO_ISF_TEMPLATE__USA = 300008
    }

    public enum EnumTIPO_PRECIO_PEDIDO
    {
        FOB = 301001
    }

    public enum EnumNAVIERAS
    {
        MSC = 302001,
        HAPAG_LLOYD = 302002,
        MAERSK = 302003,
        MOL = 302004
    }

    public enum EnumNAVES
    {
        MSC_FEDERICA_ = 303001,
        MSC_MADELEINE_ = 303002,
        MOL_PRESTIGE_1302W = 303003
    }

    public enum EnumTEMPERATURAS_PAISES
    {
        AIR_INLET_DELIVERY_SPECIFICATIONS_IN_DEGREES_CELSIUS = 304001,
        AIR_FRESH_VENTS_SETTINGS_IN_CBM___HR = 304002,
        DEHUMIDIFICATION_ = 304003,
        CONTROLLED_ATMOSPHERE_SYSTEM = 304004,
        COLD_TREATMENT = 304005,
        REGISTRO_FDA = 304006
    }

    public enum EnumTIPO_DE_MOVIMIENTO
    {
        INGRESOS = 305001,
        EGRESOS = 305002,
        TRANFERENCIA = 305003
    }

    public enum EnumTABLA_1_TIPO_DE_MEDIO_DE_PAGO
    {
        DEPOSITO_EN_CUENTA = 306001,
        GIRO = 306002,
        TRANSFERENCIA_DE_FONDOS = 306003,
        ORDEN_DE_PAGO = 306004,
        TARJETA_DE_DEBITO = 306005,
        TARJETA_DE_CREDITO = 306006,
        CHEQUES_CON_LA_CLÁUSULA_DE_NO_NEGOCIABLE_INTRANSFERIBLES_NO_A_LA_ORDEN_U_OTRA_EQUIVALENTE_A_QUE_S = 306007,
        EFECTIVO_POR_OPERACIONES_EN_LAS_QUE_NO_EXISTE_OBLIGACION_DE_UTILIZAR_MEDIOS_DE_PAGO = 306008,
        EFECTIVO_EN_LOS_DEMAS_CASOS = 306009,
        MEDIOS_DE_PAGO_DE_COMERCIO_EXTERIOR = 306010,
        LETRAS_DE_CAMBIO = 306011,
        TRANSFERENCIAS__COMERCIO_EXTERIOR = 306012,
        CHEQUES_BANCARIOS___COMERCIO_EXTERIOR = 306013,
        ORDEN_DE_PAGO_SIMPLE___COMERCIO_EXTERIOR = 306014,
        ORDEN_DE_PAGO_DOCUMENTARIO__COMERCIO_EXTERIOR = 306015,
        REMESA_SIMPLE__COMERCIO_EXTERIOR = 306016,
        REMESA_DOCUMENTARIA__COMERCIO_EXTERIOR = 306017,
        CARTA_DE_CREDITO_SIMPLE__COMERCIO_EXTERIOR = 306018,
        CARTA_DE_CREDITO_DOCUMENTARIO__COMERCIO_EXTERIOR = 306019,
        OTROS_MEDIOS_DE_PAGO = 306020,
        TARJETA_DE_CRÉDITO_EMITIDA_EN_EL_PAÍS_O_EN_EL_EXTERIOR_POR_UNA_EMPRESA_NO_PERTENECIENTE_AL_SISTEMA_F = 306021,
        TARJETAS_DE_CRÉDITO_EMITIDAS_EN_EL_EXTERIOR_POR_EMPRESAS_BANCARIAS_O_FINANCIERAS_NO_DOMICILIADAS = 306022,
        NOTA_DE_CARGO = 306023
    }

    public enum EnumTIPO_DE_AFECTACION_IGV
    {
        GRAVADO__OPERACION_ONEROSA = 307001,
        GRAVADO__RETIRO_POR_PREMIO = 307002,
        GRAVADO__RETIRO_POR_DONACION = 307003,
        GRAVADO__RETIRO = 307004,
        GRAVADO__RETIRO_POR_PUBLICIDAD = 307005,
        GRAVADO__BONIFICACIONES = 307006,
        GRAVADO__RETIRO_POR_ENTREGA_A_TRABAJADORES = 307007,
        EXONERADO__OPERACION_ONEROSA = 307008,
        INAFECTO__OPERACION_ONEROSA = 307009,
        INAFECTO__RETIRO_POR_BONIFICACION = 307010,
        INAFECTO__RETIRO = 307011,
        INAFECTO__RETIRO_POR_MUESTRAS_MEDICAS = 307012,
        INAFECTO__RETIRO_POR_CONVENIO_COLECTIVO = 307013,
        INAFECTO__RETIRO_POR_PREMIO = 307014,
        INAFECTO__RETIRO_POR_PUBLICIDAD = 307015,
        EXPORTACION = 307016
    }

    public enum EnumTABLA_31_TIPO_DE_RENTA
    {
        BIENES = 308001,
        ARRENDAMIENTOS_DE_PREDIOS = 308002,
        ENAJENACION_INMUEBLES_Y_DERECHOS_SOBRE_INMUEBLES = 308003,
        RENTAS_DE_BIENES_SITUADOS_EN_EL_PAIS_O_DERECHOS_UTILIZADOS_EN_EL_PAIS_INCLUYE_ENAJENACION = 308004,
        REGALIAS_BIENES_O_DERECHOS_POR_LOS_QUE_PAGAN_SON_UTILIZADOS_PAIS = 308005,
        REGALIAS_PAGADOR_DE_LAS_REGALIAS_ES_DOMICILIADO = 308006,
        DIVIDENDOS_Y_CUALQUIER_OTRA_FORMA_DE_DISTRIBUCIÓN_DE_UTILIDADES = 308008,
        LOS_RENDIMIENTOS_DE_LOS_ADR_Y_GDRS = 308009,
        ORIGINADAS_EN_ACTIVIDADES_CIVILES_COMERCIALES_EMPRESARIALES = 308010,
        ORIGINADAS_EN_EL_TRABAJO_PERSONAL_QUE_LLEVEN_A_CABO_EN_EL_TERRITORIO_NACIONAL_NO_COMPRENDE_CUANDO_SE = 308011,
        RENTAS_VITALICIAS_Y_LAS_PENSIONES_QUE_TENGAN_SU_ORIGEN_EN_EL_TRABAJO_PERSONAL = 308012,
        LAS_OBTENIDAS_POR_LA_ENAJENACIÓN_DE_ACCIONES_Y_PARTICIPACIONES_REPRESENTATIVAS_DEL_CAPITAL = 308013,
        LAS_OBTENIDAS_POR_LA_ENAJENACIÓN_DE_CERTIFICADOS_TÍTULOS_BONOS_Y_PAPELES_COMERCIALES = 308014,
        LAS_OBTENIDAS_POR_LA_REDENCIÓN_O_RESCATE_DE_CERTIFICADOS_TÍTULOS_BONOS_Y_PAPELES_COMERCIALES_VALO = 308015,
        LAS_OBTENIDAS_POR_LA_REDENCIÓN_O_RESCATE_DE__ACCIONES_DE_INVERSIÓN_CERTIFICADOS_TÍTULOS = 308017,
        ENAJENACIÓN_DE_LOS_ADRS_Y_GDRS_QUE_TENGAN_COMO_SUBYACENTE_ACCIONES_EMITIDAS_POR_EMPRESAS_DOMICILIADA = 308018,
        LAS_OBTENIDAS_POR_SERVICIOS_DIGITALES_PRESTADOS_A_TRAVÉS_DEL_INTERNET_O_DE_CUALQUIER_ADAPTACIÓN_O_AP = 308019,
        LA_OBTENIDA_POR_ASISTENCIA_TÉCNICA_CUANDO_ÉSTA_SE_UTILICE_ECONÓMICAMENTE_EN_EL_PAÍS = 308020,
        LOS_INTERESES_DE_OBLIGACIONES_CUANDO_LA_ENTIDAD_EMISORA_HA_SIDO_CONSTITUIDA_EN_EL_PAÍS = 308021,
        REMUNERACION_PAGADA_POR_DOMICILIADOS_SUJETO_MIEMBRO_DE_UN_CONSEJO_DIRECTIVO_O_ADM = 308022,
        HONORARIOS_O_REMUNERACIONES_DEL_SECTOR_PÚBLICO_NACIONAL_POR_TRABAJOS_REALIZADOS_EN_EL_EXTERIOR = 308023,
        RESULTADOS_PROVENIENTE_DE_LA_CONTRATACIÓN_DE_IFD = 308024,
        RESULTADOS__DE_IFD_CON_COBERTURA_DESTINADOS_A_LA_GENERACIÓN_DE_RFP = 308025,
        PROVENIENTE_DE_LA_CONTRATACIÓN_DE_IFD_SIN_COBERTURA_DESTINADOS_A_LA_GENERACIÓN_DE_RFP = 308026,
        IFD_DONDE_ACTIVO_SUBYACENTE_SEA_REFERIDO_AL_TIPO_DE_CAMBIO_MONEDA_EXTRANJERA_180_DIAS = 308027,
        LAS_OBTENIDAS_POR_LA_ENAJENACIÓN_INDIRECTA_DE_ACCIONES_Y_PARTICIPACIONES_REPRESENTATIVAS_DEL_CAPITAL = 308028,
        SE_INCLUYE_DENTRO_DE_LA_ENAJENACIÓN_DE_DE_EMPRESAS_NO_DOMICILIADAS_EN_EL_PAÍS = 308029,
        SUJETO_ES_EL_NO_DOM_QUE_DISTRIBUYE__POR_LA_REDUCCIÓN_DE_CAPITAL_DENTRO_DE_LOS_12_MESES_ANTERIORES = 308030,
        ACTIVIDADES_DE_SEGUROS_7_SOBRE_LAS_PRIMAS = 308031,
        ALQUILER_DE_NAVES_8_SOBRE_INGRESOS_BRUTOS_QUE_PERCIBAN_POR_DICHA_ACTIVIDAD = 308032
    }

    public enum EnumCRITERIO_SUBJETIVO
    {
        ACTITUD = 309001,
        CONOCIMIENTO_DEL_CANAL_ = 309002,
        CONOCIMIENTO_DE_LA_COMPETENCIA = 309003
    }

    public enum EnumITEMS_UBICACION
    {
        HANGAR_01 = 310001,
        HANGAR_02 = 310002,
        HANGAR_03 = 310003,
        HANGAR_04 = 310004,
        HANGAR_05 = 310005,
        EDIFICIO_ADMINISTRATIVO = 310006,
        LOCAL_BRITTAN = 310007,
        PATIO_DE_VEHICULOS = 310008,
        LABORATORIO = 310009,
        CONTROL_DE_CALIDAD = 310010
    }

    public enum EnumITEMS_FALLAS
    {
        CAMBIO_DE_RESPUESTO = 311001,
        CORTO_ELECTRICO = 311002,
        NO_IDENTIFICADO = 311003,
        FALLA_ELÉCTRICA = 311005,
        FALLA_MECÁNICA = 311006,
        FALLA_ELÉCTRICA_MECÁNICA = 311007
    }

    public enum EnumITEMS_MANTENIMIENTO
    {
        LUBRICAR_COMPONENTES = 312001,
        CAMBIO_DE_PIEZA = 312002
    }

    public enum EnumITEMS_AREA_USUARIO
    {
        PRODUCCION = 313001,
        ALMACEN_PT = 313002,
        LABORATORIO = 313003,
        OFICINAS_ADMINISTRATIVAS = 313004,
        ALMACEN_MP = 313005,
        CONTROL_DE_CALIDAD = 313006,
        PESADO_DE_INSUMOS = 313007,
        MANTENIMIENTO = 313008,
        LOGISTICA = 313009,
        REPARTO = 313010,
        IMPORTACIONES = 313011,
        VENTAS = 313012
    }

    public enum EnumITEMS_PROGRAMABLES
    {
        ENGRASE_DE_PARTES_MOVILES = 314001,
        REVISION_GENERAL_DEL_EQUIPO = 314002,
        LIMPIEZA_E_INSPECCION_GENERAL = 314003,
        LIMPIEZA = 314004,
        VERIFICACION_DEL_ESTADO_DE_LAS_FAJAS_POLEAS = 314005,
        VERIFICACION_DE_LA_ENTRADA_DE_AGUA_ELECTROVALVULA = 314006,
        VERIFICACION_DE_RUIDOS = 314007,
        VERIFICACION_DEL_ESTADO_DE_RODAMIENTOS = 314008,
        VERIFICACION_DEL_ESTADO_DE_AMORTIGUADORES_Y_ESTADO_DE_FAJA_DEL_MOTOR = 314009,
        VERIFICACION_GENERAL_DE_LOS_MOTORES_VENTILADORES_Y_VIBRADORES = 314010,
        CAMBIO_DE_FILTROS = 314011,
        CAMBIO_DE_ACEITE_DE_CAJA_DE_RECUCTOR = 314012,
        CAMBIO_DE_RETENES = 314013,
        CAMBIO_DE_AGUA_SI_LO_REQUIERE = 314014,
        _CAMBIO_DE_FILTROS = 314015,
        _CAMBIO_DE_RETENES = 314016,
        _LIMPIEZA_GENERAL_DE_LA_BOMBA_DE_VACIÓ = 314018,
        _VERIFICACIÓN_GENERAL_DE_LOS_MOTORES_VENTILADORES_Y_VIBRADORES_ = 314019,
        CAMBIO_DE_ACEITE_DE_CAJA_DE_REDUCTOR = 314020,
        INSPECCIÓN_DE_EMPAQUETADURA_Y_PRENSAESTOPAS_DEL_EJE_PRINCIPALINSPECCIÓN_DE_EMPAQUETADURA_Y_PRENSAEST = 314023,
        INSPECCIÓN_DE_MOTOR_TURBINA_ = 314024,
        INSPECCIÓN_DE_RODAJES = 314025,
        INSPECCIÓN_DE_SONIDOS_EN_LA_BOMBA_DEL_SISTEMA = 314026,
        INSPECCIÓN_DEL_SISTEMA_NEUMÁTICO_VÁLVULAS_Y_BOMBAS = 314027,
        INSPECCION_GENERAL_DEL_MOTOR = 314028,
        INSPECCION_GENERAL_DEL_SISTEMA_ELECTRICO = 314029,
        LIMPIEZA_DE_FILTROS = 314031,
        LIMPIEZA_E_INSPECCION_GENERAL_DEL_SISTEMA_ELECTRICO = 314032,
        LIMPIEZA_E_INSPECCION_DEL_SISTEMA_MECANICO = 314033,
        LIMPIEZA_GENERAL_DE_LA_BOMBA_DE_VACÍO = 314035,
        LIMPIEZA_INTERNA_DE_TANQUE_DE_INTERCAMBIADOR_SISTEMA_DE_ENFRIAMIENTO_CAÑERÍAS = 314036,
        LIMPIEZA_Y_VERIFICACION_DE_FUNCIONAMIENTO_DEL_SISTEMA_ELECTRICO = 314037,
        REVISION_DEL_SISTEMA_ELECTRICO = 314038,
        VERIFICACIÓN_DE_AMORTIGUADORES_Y_ESTADO_DE_FAJA_DE_MOTOR = 314040,
        VERIFICACIÓN_DE_FAJA = 314041,
        VERIFICACIÓN_DE_LOS_RODAMIENTOS_DE_MOTOR_EXTRACTOR = 314043,
        VERIFICACIÓN_DE_RODAMIENTOS_Y_POTENCIA_DE_SUCCIÓN = 314044,
        VERIFICACION_DEL_FUNCIONAMIENTO_Y_EL_SISTEMA_ELECTRICO = 314048,
        VERIFICACIÓN_GENERAL_DE_LOS_MOTORES_IMPULSORES_Y_VENTILADORES = 314049,
        FALLA_ELÉCTRICA = 314050,
        FALLA_MECÁNICA = 314051,
        FALLA_ELÉCTRICA_MECÁNICA = 314052,
        MODIFICACIÓN_ELÉCTRICA = 314053,
        MODIFICACIÓN_MECÁNICA = 314054,
        MODIFICACIÓN_ELÉCTRICA_MECÁNICA = 314055
    }

    public enum EnumITEMS_INTERVENCION
    {
        CAMBIO_DE_PIEZA = 315001,
        CAMBIO_DE_ACEITE = 315002,
        LUBRICAR_PARTES_MOVILES = 315003,
        FALLA_ELÉCTRICA = 315004,
        FALLA_MECÁNICA = 315005,
        FALLA_ELÉCTRICA_MECÁNICA = 315006
    }

    public enum EnumITEMS_ESTADO
    {
        PENDIENTE = 316002,
        TERMINADO = 316003,
        ANULADO = 316004
    }

    public enum EnumITEMS_PRIORIDAD
    {
        NORMAL = 317001,
        ALTA = 317002,
        BAJA = 317003
    }

    public enum EnumITEMS_FRECUENCIA
    {
        MES_1 = 318001,
        MESES_2 = 318002,
        MESES_3 = 318003,
        MESES_6 = 318004
    }

    public enum EnumITEMS_ESTADO_ARTICULO
    {
        PENDIENTE = 319001,
        ENTREGADO = 319002,
        SOLICITADO = 319003
    }

    public enum EnumITEMS_CARACTERISTICA
    {
        TIPO = 322001,
        CULTIVO = 322002,
        ESPECIE = 322003,
        VARIEDAD = 322004
    }

    public enum EnumITEMS_ACCIONES
    {
        MECANICO = 323001,
        ELECTRICO = 323002
    }

    public enum EnumITEMS_TRABAJO
    {
        PARADA_POR_MANTENIMIENTO = 324001,
        PARADA_POR_USUARIO = 324002,
        EN_FUNCIONAMIENTO = 324003,
        PARADA_POR_FALLA = 324004
    }

    public enum EnumITEMS_GRUPO
    {
        MEC = 326001,
        ELEC = 326002,
        TERCERO = 326004,
        MEC_Y_ELEC = 326006,
        MTTO = 326007
    }

    public enum EnumCORRELATIVO_ALMACEN
    {
        CORRELATIVO_SIMPLE = 327001,
        CORRELATIVO_AÑO_Y_MES = 327002,
        CORRELATIVO_ANUAL = 327003
    }

    public enum EnumITEMS_CATEGORIA_TRABAJADOR
    {
        USUARIO = 328001,
        MANTENIMIENTO = 328002
    }

    public enum EnumITEMS_CHECKLIST_VEHICULO
    {
        SI = 329001,
        NO = 329002
    }

    public enum EnumTABLA_11_CÓDIGO_DE_LA_ADUANA
    {
        TUMBES = 330001,
        TALARA = 330002,
        PAITA = 330003,
        CHICLAYO = 330004,
        SALAVERRY = 330005,
        CHIMBOTE = 330006,
        MARÍTIMA_DEL_CALLAO = 330007,
        PISCO = 330008,
        MOLLENDO_MATARANI = 330009,
        AREQUIPA = 330010,
        ILO = 330011,
        TACNA = 330012,
        PUNO = 330013,
        CUZCO = 330014,
        PUCALLPA = 330015,
        IQUITOS = 330016,
        AEREA_DEL_CALLAO = 330017,
        POSTAL_DE_LIMA = 330018,
        DESAGUADERO = 330019,
        TARAPOTO = 330020,
        PUERTO_MALDONADO = 330021,
        LA_TINA = 330022,
        DEPENDENCIA_FERROVIARIA_TACNA = 330023,
        DEPENDENCIA_POSTAL_TACNA = 330024,
        DEPENDENCIA_POSTAL_AREQUIPA = 330025,
        COMPLEJO_FRONTERIZO_STA_ROSA_TACNA = 330026,
        TERMINAL_TERRESTRE_TACNA = 330027,
        AEROPUERTO_TACNA = 330028,
        CETICOS_TACNA = 330029,
        DEPENDENCIA_POSTAL_DE_SALAVERRY = 330030
    }

    public enum EnumITEMS_SEMANAS
    {
        semana_01 = 332001,
        semana_02 = 332002,
        semana_03 = 332003,
        semana_04 = 332004,
        semana_05 = 332005,
        semana_06 = 332006,
        semana_07 = 332007,
        semana_08 = 332008,
        semana_09 = 332009,
        semana_10 = 332010,
        semana_11 = 332011,
        semana_12 = 332012,
        semana_13 = 332013,
        semana_14 = 332014,
        semana_15 = 332015,
        semana_16 = 332016,
        semana_17 = 332017,
        semana_18 = 332018,
        semana_19 = 332019,
        semana_20 = 332020,
        semana_21 = 332021,
        semana_22 = 332022,
        semana_23 = 332023,
        semana_24 = 332024,
        semana_25 = 332025,
        semana_26 = 332026,
        semana_27 = 332027,
        semana_28 = 332028,
        semana_29 = 332029,
        semana_30 = 332030,
        semana_31 = 332031,
        semana_32 = 332032,
        semana_33 = 332033,
        semana_34 = 332034,
        semana_35 = 332035,
        semana_36 = 332036,
        semana_37 = 332037,
        semana_38 = 332038,
        semana_39 = 332039,
        semana_40 = 332040,
        semana_41 = 332041,
        semana_42 = 332042,
        semana_43 = 332043,
        semana_44 = 332044,
        semana_45 = 332045,
        semana_46 = 332046,
        semana_47 = 332047,
        semana_48 = 332048
    }

    public enum EnumTABLA_5_TIPO_DE_EXISTENCIA
    {
        MERCADERIAS = 333001,
        PRODUCTOS_TERMINADOS = 333002,
        MATERIAS_PRIMAS = 333003,
        ENVASES = 333004,
        INSUMOS = 333005,
        SUMINISTROS = 333006,
        REPUESTOS = 333007,
        EMBALAJES = 333008,
        SUBPRODUCTOS = 333009,
        DESECHOS_Y_DESPERDICIOS = 333010,
        SERVICIOS = 333018
    }

    public enum EnumEMPRESA_ASEGURADORA
    {
        PERSALUD = 334001,
        PACIFICO_SA = 334002,
        RIMAC_INTERNATIONAL = 334003,
        SERVICIOS_PROPIOS = 334004
    }

    public enum EnumSEDE
    {
        ADMINISTRATIVO = 335001,
        SUPERFICIE = 335002,
        SOCABON_O_INTERIOR = 335003
    }

    public enum EnumELEMENTOS_DE_COSTOS
    {
        PRODUCTOS_TERMINADOS = 336002,
        ETIQUETAS = 336003,
        PIGMENTOS = 336004,
        STRECH_FILM = 336005,
        SERVICIOS = 336006
    }

    public enum EnumCONCEPTOS_PARA_COMPRAS
    {
        GASTOS = 337001,
        SERVICIOS = 337002,
        ACTIVOS = 337003,
        VARIOS = 337004
    }

    public enum EnumTIPO_PLANILLA_DE_COBRANZAS
    {
        EFECTIVO = 338001,
        CREDITOS = 338002,
        ANTICIPOS = 338003,
        ABONO_DE_LETRAS = 338004,
        COMPENSACIONES = 338005,
        OTROS_INGRESOS = 338006,
        DETRACCIÓN = 338007,
        APLICACION_NOTA_CREDITO_Y_OTROS = 338008,
        ABONO_LETRAS_EN_DSCTO_O_ENDOSADA = 338009,
        RETENCIONES = 338010,
        CANC_LETRAS_EN_DSCTO_O_ENDOSADA = 338011,
        ABONO_FACTNEGOEN_DSCTO_O_ENDOSADA = 338012,
        FN_CANCFACTNEGOEN_DSCTO_O_ENDOSADA = 338013,
        RECLASIFICA = 338014,
        OTRAS_COBRANZAS = 338015
    }

    public enum EnumOTROS
    {

    }

    public enum EnumTABLA_12_TIPO_DE_OPERACION
    {
        VENTA_NACIONAL = 340001,
        COMPRA_NACIONAL = 340002,
        CONSIGNACION_RECIBIDA = 340003,
        CONSIGNACION_ENTREGADA = 340004,
        DEVOLUCION_RECIBIDA = 340005,
        DEVOLUCION_ENTREGADA = 340006,
        BONIFICACION = 340007,
        PREMIO = 340008,
        DONACION = 340009,
        SALIDA_A_PRODUCCION = 340010,
        SALIDA_POR_TRANSFERENCIA_ENTRE_ALMACENES = 340011,
        RETIRO = 340012,
        MERMAS = 340013,
        DESMEDROS = 340014,
        DESTRUCCION = 340015,
        SALDO_INICIAL = 340016,
        EXPORTACION = 340017,
        IMPORTACION = 340018,
        ENTRADA_DE_PRODUCCION = 340019,
        ENTRADA_POR_DEVOLUCION_DE_PRODUCCION = 340020,
        ENTRADA_POR_TRANSFERENCIA_ENTRE_ALMACENES = 340021,
        ENTRADA_POR_IDENTIFICACION_ERRONEA = 340022,
        SALIDA_POR_IDENTIFICACION_ERRONEA = 340023,
        ENTRADA_POR_DEVOLUCION_DEL_CLIENTE = 340024,
        SALIDA_POR_DEVOLUCION_AL_PROVEEDOR = 340025,
        ENTRADA_PARA_SERVICIO_DE_PRODUCCION = 340026,
        SALIDA_POR_SERVICIO_DE_PRODUCCION = 340027,
        AJUSTE_POR_DIFERENCIA_DE_INVENTARIO = 340028,
        ENTRADA_POR_BIENES_EN_PRESTAMO = 340029,
        SALIDA_DE_BIENES_EN_PRESTAMO = 340030,
        ENTRADA_DE_BIENES_EN_CUSTODIA = 340031,
        SALIDA_DE_BIENES_EN_CUSTODIA = 340032,
        MUESTRAS_MEDICAS = 340033,
        PUBLICIDAD = 340034,
        GASTOS_DE_REPRESENTACION = 340035,
        RETIRO_PARA_ENTREGA_A_TRABAJADORES = 340036,
        RETIRO_POR_CONVENIO_COLECTIVO = 340037,
        RETIRO_POR_SUSTITUCIÓN_DE_BIEN_SINIESTRADO = 340038,
        OTROS_1_INGRESO_POR_CAMBIO_DE_CODIGO = 340039,
        OTROS_2_SALIDA_POR_CAMBIO_DE_CODIGO = 340040,
        OTROS_3_INGRESO_AJTE_COSTO = 340041,
        OTROS_4_SALIDA_AJTE_COSTO = 340042,
        OTROS_5_INGRESO_POR_INSUMO_DE_2DO_USO = 340043,
        OTROS_6_SALIDA_DE_MUESTRAS = 340044,
        OTROS_7__TRANSFERENCIA_GRATUITA = 340045,
        OTROS_8_SALIDA_POR_INSUMO_DE_2DO_USO = 340046,
        OTROS_9 = 340047
    }

    public enum EnumCONSIGNACION_ENTREGADA
    {

    }



    public enum EnumVINCULO_FAMILIAR
    {
        HIJO = 343001,
        CONYUGE = 343002,
        CONCUBINO = 343003,
        GESTANTE = 343004
    }

    public enum EnumTIPO_DE_BAJA_DERECHO_HABIENTE

    {
        FALLECIMIENTO = 344001,
        OTROS = 344002,
        DIVORCIO_O_DISOLUCION_DE_VINCULO_MATRIMONIAL = 344003,
        FIN_DE_CONCUBINATO = 344004,
        FIN_DE_LA_GESTACION = 344005,
        HIJO_MAYOR_DE_EDAD = 344006

    }

    public enum EnumCONCEPTO_PARA_PREGUNTAS
    {
        TENENCIA = 345001,
        MATERIAL = 345002,
        TIPO_VIVIENDA = 345003,
        SERVICIOS = 345004,
        ZONA = 345005,
        INFRAESTRUCTURA = 345006,
        NUMERO_DE_AMBIENTES = 345007,
        MOBILIARIO = 345008
    }

    public enum EnumCONCEPTO_RESPUESTAS_TENENCIA
    {
        PROPIA = 346001,
        ALQUILADA = 346002,
        ALOJADA = 346003,
        GUARDIAN = 346004,
        OTROS = 346005
    }

    public enum EnumCONCEPTO_RESPUESTAS_MATERIAL
    {
        NOBLE = 347001,
        CONCRETO = 347002,
        ESTERAS = 347003,
        CALAMINAS = 347004,
        ADOBE = 347005,
        QUINCHA = 347006,
        TAPIA = 347007,
        OTROS = 347008
    }

    public enum EnumCONCEPTO_RESPUESTA_TIPO_VIVIENDA
    {
        INDEPENDIENTE = 348001,
        DEPARTAMENTO = 348002,
        QUINTA = 348003,
        CORRALÓN = 348004,
        CALLEJÓN = 348005,
        OTROS = 348006
    }

    public enum EnumCONCEPTO_RESPUESTAS_SERVICIOS
    {
        LUZ = 349001,
        AGUA = 349002,
        TELÉFONO = 349003,
        CABLE = 349004,
        INTERNET = 349005,
        DESAGUE = 349006,
        SIN_SERVICIO = 349007
    }

    public enum EnumCONCEPTO_RESPUESTA_ZONA
    {
        RESIDENCIAL = 350001,
        URBANA = 350002,
        POPULAR = 350003,
        AAHH = 350004,
        CASERÍO = 350005,
        OTROS = 350006
    }

    public enum EnumCONCEPTO_RESPUESTA_INFRAESTRUCTURA
    {
        CONSTRUIDA = 351001,
        SEMI_CONSTRUIDA = 351002,
        PROVISIONAL = 351003,
        OTROS = 351004
    }

    public enum EnumCONCEPTO_RESPUESTA_N_DE_AMBIENTES
    {

        UNO = 352001,
        DOS = 352002,
        TRES = 352003,
        CUATRO = 352004,
        CINCO = 352005,
        SEIS = 352006,
        OTROS = 352007
    }

    public enum EnumCONCEPTO_RESPUESTA_MOBILIARIO
    {
        SUFICIENTE = 353001,
        INSUFICIENTE = 353002,
        CARENTE = 353003
    }

    public enum EnumCONCEPTO_RESPUESTA_CRIANZA_DE_AVES
    {
        SI = 354001,
        NO = 354002
    }

    public enum EnumPREGUNTAS_DE_SALUD
    {
        UD_PADECE_ALGUNA_ENFERMEDAD_ALERGIA_QUE_IMPLIQUE_SER_CONOCIDA_PARA_DAR_ATENCION_MEDICA_OPORTUNA = 355001,
        ES_UD_ALERGICO_A_LA_PICADURA_DE_INSECTO = 355002,
        SI_UD_ES_DEL_SEXO_FEMENINO_SE_ENCUENTRA_GESTANDO_ = 355003,
        SI_UD_ES_MASCULINO_SU_ESPOSA_CONVIVIENTE_SE_ENCUENTRA_GESTANDO_ = 355004
    }

    public enum EnumACTIVIDADES_TRABAJADOR
    {
        ARTISTICAS = 356001,
        RECREATIVAS = 356002,
        DEPORTISTAS = 356003
    }


    public enum EnumGRUPO_CONCEPTO
    {
        REFERENCIALES = 358001,
        REM_ASIGNADA = 358002,
        REMUNERACIONES = 358003,
        RETENCIONES = 358004,
        OTROS_DSCTO = 358005,
        APORTE = 358006
    }

    public enum EnumTIPO_CONCEPTO
    {
        REFERENCIALES = 359001,
        INGRESOS = 359002,
        RETENCIONES = 359003,
        OTROS_DSCTOS = 359004,
        APORTACIONES = 359005,
        SISTEMA = 359006
    }

    public enum EnumTIPO_DATO
    {
        DIAS = 360001,
        HORAS = 360002,
        MONTO_O_NINGUNO = 360003
    }

    public enum EnumTIPO_REMUNERACION
    {
        REMUNERACION_BASICA = 361001,
        HORAS_EXTRA = 361002,
        OTRAS_REMUNERACIONES = 361003,
        GRAFICACION = 361004,
        VACACIONES = 361005,
        CTS = 361006,
        DESCUENTOS = 361007,
        APORTES = 361008,
        NINGUNO = 361009
    }

    public enum EnumAFECTO_VAC
    {
        PROMEDIO_6_ULT_MESES = 362001,
        AFECTO = 362002,
        NO_AFECTO = 362003
    }

    public enum EnumAFECTO_CTS
    {
        PROMEDIO_6_ULT_MESES = 363001,
        AFECTO = 363002,
        NO_AFECTO = 363003
    }

    public enum EnumAFECTO_GRA
    {
        PROMEDIO_6_ULT_MESES = 364001,
        AFECTO = 364002,
        NO_AFECTO = 364003
    }

    public enum EnumDIAS_AFECTO_UTIL
    {
        SI = 366001,
        NO = 366002
    }

    public enum EnumDIAS_AFECTO_GRATI
    {
        SI = 367001,
        NO = 367002
    }

    public enum EnumCOPIAR_CONCEPTO
    {
        SI = 368001,
        NO = 368002
    }

    public enum EnumTIPO_CALCULO
    {
        VALOR_CERO = 369001,
        CALCULO_SEGUN_FORMULA = 369002,
        INGRESO_MANUAL = 369003,
        CALCULO_DEFINIDO = 369004,
        REM_ASIGNADA = 369005,
        CTS_MENSUAL = 369006,
        APLIC_RETENCION = 369007,
        APLIC_APORTACION = 369008
    }

    public enum EnumTIPO_DE_OPERACION_DETRACCION_SUNAT

    {
        VENTA_DE_BIENES_O_PRESTACIÓN_DE_SERVICIOS = 371001,
        RETIRO_DE_BIENES = 371002,
        TRASLADOS_QUE_NO_SON_VENTAS = 371003,
        VENTA_A_TRAVES_DE_LA_BOLSA_DE_PRODUCTOS = 371004,
        VENTA_DE_BIENES_EXONERADOS_DEL_IGV = 371005
    }

    public enum EnumNOMBRE_DIA
    {
        Lunes = 374001,
        Martes = 374002,
        Miércoles = 374003,
        Jueves = 374004,
        Viernes = 374005,
        Sabado = 374006,
        Domingo = 374007
    }

    public enum EnumMARCACION_DE_ASISTENCIA
    {
        TOLERANCIA_ENTRADA = 375001,
        COSTO_REFRIGERIO = 375002
    }


    public enum EnumTIPO_CANAL
    {
        EXPORTACIONES = 378001,
        HORIZONTAL_LIMA_Y_CALLAO = 378002,
        MARKETING = 378003,
        HORECA = 378004,
        AASS = 378005,
        TIENDA_ICA = 378006,
        INSTITUCIONAL = 378007,
        DIGITAL_LIMA = 378008,
        A_SELECCIONAR = 378009,
        HORIZONTAL_PROVINCIA = 378010,
        TIENDAS_DE_CONVENIENCIA = 378011,
        AEROPUERTO = 378012,
        CASH_AND_CARRY = 378013,
        LIMA_DISTRIBUIDORES = 378014,
        LIMA_HIBRIDOS = 378015,
        PROVINCIAS_SUR = 378016,
        PROVINCIAS_NORTE = 378017,
        PROVINCIAS_CENTRO = 378018,
        BACKUS = 378019,
        PANACA = 378020,
        GERENCIA_GENERAL = 378021,
        OTROS = 378022
    }

    public enum EnumCLASIFICA_CONDICION_DE_VENTA
    {
        CONTADO = 381001,
        FACTURA = 381002,
        LETRA = 381003,
        FACTURA_NEGOCIABLE = 381004,
        ANTICIPO = 381005,
        TRANS_GRATUITA = 381006,
        MUESTRA = 381007,
        POR_DEFINIR = 381008,
        EXPORTACION = 381009
    }

    public enum EnumGERENCIA_RESPONSABLE
    {
        OFF_PREMISE = 382001,
        ON_PREMISE = 382002,
        EXPORTACION = 382003,
        A_SELECCIONAR = 382004,
        GERENCIA_GENERAL = 382005,
        MARKETING = 382006,
        OTROS = 382007,
        RRHH = 382008,
        LOGISTICA = 382009
    }

    public enum EnumCLASE_DE_CANAL
    {
        ON_PREMISE = 383001,
        OFF_PREMISE = 383002,
        EXPORTACION = 383003,
        TODOS = 383004,
        GERENCIA_GENERAL = 383005,
        MARKETING = 383006,
        OTROS = 383007
    }

    public enum EnumTIPO_ISC
    {
        ISC = 384001
    }

    public enum EnumTIPO_DE_PROCESO_DE_VINO
    {
        EMBOTELLADO = 386001,
        SEMI_EMBOTELLADO = 386002,
        ETIQUETADO = 386003,
        DES_EMBOTELLADO = 386004
    }

    public enum EnumTIPO_DE_OPERACION_DE_VINO
    {
        PRODUCCION = 387001,
        REPROCESO = 387002,
        DES_EMBOTELLADO = 387003,
        TRANSFERENCIA = 387004,
        SALIDA_DE_INSUMOS = 387005,
        RE_ETIQUETADO = 387006
    }

    public enum EnumCALIFICACION_DE_CLIENTES
    {
        NORMAL = 388001,
        TOP = 388002,
        SEGUIMIENTO = 388003,
        RIESGOSO = 388004,
        JUDICIAL = 388005,
        SINIESTRO = 388006,
        REFINANCIADO = 388007
    }

    public enum EnumCALIDAD_
    {
        SIN_CALIDAD = 390001,
        CERTIFICACION_PEFC = 390002,
        CERTIFICACION_FSC = 390003
    }
}
