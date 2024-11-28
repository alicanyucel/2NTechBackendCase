posgtrsql kullanýcý adý:myusername
þifre:mypassword
auth controllerden token almak için username:"admin"
password=1  yazabilirsiniz
docker cmd 
C:\Users\Ali Can>docker ps
CONTAINER ID   IMAGE      COMMAND                  CREATED       STATUS          PORTS                    NAMES
ed20e9b76eaf   postgres   "docker-entrypoint.s…"   2 hours ago   Up 41 minutes   0.0.0.0:5432->5432/tcp   postgresql
b18c14aaae12   postgres   "docker-entrypoint.s…"   2 hours ago   Up 2 hours      5432/tcp                 some-postgres

C:\Users\Ali Can>docker exec -it <ed20e9b76eaf> bash
Sistem belirtilen dosyayı bulamıyor.

C:\Users\Ali Can>docker exec -it ed20e9b76eaf bash
root@ed20e9b76eaf:/# psql -U myusername -d mydb
psql: error: connection to server on socket "/var/run/postgresql/.s.PGSQL.5432" failed: FATAL:  database "mydb" does not exist
root@ed20e9b76eaf:/# psql -U myusername -d postgres
psql (17.2 (Debian 17.2-1.pgdg120+1))
Type "help" for help.

postgres=# dt
postgres-# /dt
postgres-# /dt
postgres-# select * from user
postgres-# /dt select * from appuser
postgres-# dt select * from user
postgres-# select * from postgres
postgres-# /dt postgres
postgres-#
postgres-#
postgres-#
postgres-# 1
postgres-#
