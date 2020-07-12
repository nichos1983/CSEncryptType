## CSEncryptType

Enrypted data types for Unity games to defend against memory cheat tools, which could search the memory of critical datas and change their values. Use the encrypted types other than built-in data types for critical datas such as player blood, the number of coins, etc.

### Features

The encrypted types supported:

- EncryptByte
- EncryptSByte
- EncryptShort
- EncryptUShort
- EncryptInt
- EncryptUInt
- EncryptLong
- EncryptULong
- EncryptFloat
- EncryptDouble

Just replace the existing built-in data types with them. No code needs to change, since the type conversion operators will handle the work.

---

## CSEncryptType

用于Unity游戏项目的加密数据类型，可防御常见的内存破解/外挂工具，比如八门神器，葫芦侠，烧饼修改器等。常用于加密游戏中的关键数据类型，比如玩家血量，金币数量等

### Features

支持的加密类型:

- EncryptByte
- EncryptSByte
- EncryptShort
- EncryptUShort
- EncryptInt
- EncryptUInt
- EncryptLong
- EncryptULong
- EncryptFloat
- EncryptDouble

只需要把项目中已有的内置数据类型替换为加密类型。不需要改其他代码，类型转换操作符会处理剩下的事情
