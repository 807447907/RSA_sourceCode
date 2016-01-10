def cal(a,b,c):
    ans=1;
    while(b):
        if(b&1):
            ans*=a
        a*=a
        b>>=1
        if(a>=c):
            a%=c
        if(ans>=c):
            ans%=c
    return ans;
#########################################################################
def ras_pri(path_pri,path_in,path_out):
    priKey=open(path_pri)
    n,d=priKey.read().split()
    n=int(n)
    d=int(d)
    priKey.close()
    IN=open(path_in,'r')
    OUT=open(path_out,'w')
    data=IN.readline()
    while (data!=""):
        OUT.write(str(cal(int(data),d,n))+'\n')
        data=IN.readline()
    IN.close()
    OUT.close()
#########################################################################
def ras_pub(path_pub,path_in,path_out):
    pubKey=open(path_pub)
    n,e=pubKey.read().split()
    n=int(n)
    e=int(e)
    pubKey.close()
    IN=open(path_in,'r')
    OUT=open(path_out,'w')
    data=IN.readline()
    while (data!=""):
        OUT.write(str(cal(int(data),e,n))+'\n')
        data=IN.readline()
    IN.close()
    OUT.close()
#########################################################################
def demo_cal(a,b,c):
    a=int(a)
    b=int(b)
    c=int(c)
    ans=1;
    while(b):
        if(b&1):
            ans*=a
        a*=a
        b>>=1
        if(a>=c):
            a%=c
        if(ans>=c):
            ans%=c
    return str(ans);
