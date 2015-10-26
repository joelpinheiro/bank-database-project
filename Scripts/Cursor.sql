EXEC Sp_findstringintable 
  'tuga', 
  dbo, 
  balcao 

CREATE PROCEDURE Sp_findstringintable @stringToFind VARCHAR(100), 
                                      @schema       SYSNAME, 
                                      @table        SYSNAME 
AS 
    DECLARE @sqlCommand VARCHAR(8000) 
    DECLARE @where VARCHAR(8000) 
    DECLARE @columnName SYSNAME 
    DECLARE @cursor VARCHAR(8000) 

  BEGIN try 
      SET @sqlCommand = 'SELECT * FROM [' + @schema + '].[' + @table 
                        + '] WHERE' 
      SET @where = '' 
      SET @cursor = 'DECLARE col_cursor CURSOR FOR SELECT COLUMN_NAME     FROM ' + Db_name() 
                    + '.INFORMATION_SCHEMA.COLUMNS     WHERE TABLE_SCHEMA like ''' + @schema 
                    + '''     AND TABLE_NAME like ''%' + @table 
                    + 
'%''     AND DATA_TYPE IN (''char'',''nchar'',''ntext'',''nvarchar'',''text'',''varchar'')' 

    EXEC (@cursor) 

    OPEN col_cursor 

    FETCH next FROM col_cursor INTO @columnName 

    WHILE @@FETCH_STATUS = 0 
      BEGIN 
          IF @where <> '' 
            SET @where = @where + ' OR' 

          SET @where = @where + ' [' + @columnName + '] LIKE ''%' 
                       + @stringToFind + '%''' 

          FETCH next FROM col_cursor INTO @columnName 
      END 

    CLOSE col_cursor 

    DEALLOCATE col_cursor 

    SET @sqlCommand = @sqlCommand + @where 

    --PRINT @sqlCommand  
    EXEC (@sqlCommand) 
END try 

  BEGIN catch 
      PRINT 'Houve um erro. Verifique se o objecto existe!' 

      IF Cursor_status('variable', 'col_cursor') <> -3 
        BEGIN 
            CLOSE col_cursor 

            DEALLOCATE col_cursor 
        END 
  END catch 