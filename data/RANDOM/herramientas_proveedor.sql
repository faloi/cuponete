create procedure RANDOM.ArmarCupon @descripcion nvarchar(255), @fec_publicacion datetime, @fec_venc_oferta datetime, @fec_venc_canje datetime, @precio_real numeric(18,2), @precio_ficticio numeric(18,2), @cant_disp numeric(18,0), @cant_max_por_usuario numeric(18,0)
as
begin