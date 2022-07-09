# CSharpLearning

𝐕𝐚𝐫𝐢𝐚𝐛𝐥𝐞𝐬

- Static variables, instance variables and array elements are 𝐚𝐮𝐭𝐨𝐦𝐚𝐭𝐢𝐜𝐚𝐥𝐥𝐲 𝐢𝐧𝐢𝐭𝐢𝐚𝐥𝐢𝐳𝐞𝐝 𝐭𝐨 𝐭𝐡𝐞𝐢𝐫 𝐝𝐞𝐟𝐚𝐮𝐥𝐭 𝐯𝐚𝐥𝐮𝐞𝐬.
- Variables using 𝐯𝐚𝐫 is called 𝐈𝐦𝐩𝐥𝐢𝐜𝐢𝐭𝐲 𝐓𝐲𝐩𝐞𝐝 𝐕𝐚𝐫𝐢𝐚𝐛𝐥𝐞. => The C# compliler will 𝐝𝐞𝐭𝐞𝐫𝐦𝐢𝐧𝐞 𝐢𝐭𝐬 𝐭𝐲𝐩𝐞 at compile-time 𝐛𝐚𝐬𝐞𝐝 𝐨𝐧 𝐭𝐡𝐞 𝐯𝐚𝐥𝐮𝐞 𝐚𝐬𝐬𝐢𝐠𝐧𝐞𝐝 𝐭𝐨 𝐢𝐭. You can't assign a 𝐧𝐮𝐥𝐥 because if the value is 𝐧𝐮𝐥𝐥, then it 𝐜𝐚𝐧'𝐭 𝐝𝐞𝐜𝐢𝐝𝐞 𝐭𝐡𝐞 𝐭𝐲𝐩𝐞.
- The C# compliler will 𝐧𝐨𝐭 𝐜𝐡𝐞𝐜𝐤 for the type of a 𝐝𝐲𝐧𝐚𝐦𝐢𝐜 𝐯𝐚𝐫𝐢𝐚𝐛𝐥𝐞. The type of a dynamic variable will be 𝐝𝐞𝐭𝐞𝐫𝐦𝐢𝐧𝐞 𝐚𝐭 𝐭𝐡𝐞 𝐫𝐮𝐧𝐭𝐢𝐦𝐞 based on the value it holds at runtime. It can 𝐡𝐨𝐥𝐝 𝐚𝐧𝐲 𝐭𝐲𝐩𝐞 𝐨𝐟 𝐯𝐚𝐥𝐮𝐞 𝐚𝐭 𝐫𝐮𝐧𝐭𝐢𝐦𝐞, and 𝐧𝐨𝐭 𝐭𝐢𝐞𝐝 𝐮𝐩 𝐭𝐨 𝐭𝐡𝐞 𝐬𝐩𝐞𝐜𝐢𝐟𝐢𝐜 𝐝𝐚𝐭𝐚 𝐭𝐲𝐩𝐞. 

---oOo---

𝐈𝐧𝐝𝐞𝐱𝐞𝐫

𝐈𝐧𝐝𝐞𝐱𝐞𝐫 (𝐛𝐨̣̂ 𝐥𝐚̣̂𝐩 𝐜𝐡𝐢̉ 𝐦𝐮̣𝐜):
- Một loại thuộc tính đặc biệt 𝐜𝐡𝐨 𝐩𝐡𝐞́𝐩 𝐦𝐨̣̂𝐭 𝐜𝐥𝐚𝐬𝐬 𝐡𝐨𝐚̣̆𝐜 𝐬𝐭𝐫𝐮𝐜𝐭 đ𝐮̛𝐨̛̣𝐜 𝐭𝐫𝐮𝐲 𝐜𝐚̣̂𝐩 𝐧𝐡𝐮̛ 𝐦𝐨̣̂𝐭 𝐦𝐚̉𝐧𝐠
- Có thể được định nghĩa 𝐠𝐢𝐨̂́𝐧𝐠 𝐧𝐡𝐮̛ 𝐭𝐡𝐮𝐨̣̂𝐜 𝐭𝐢́𝐧𝐡 𝐯𝐨̛́𝐢 𝐭𝐮̛̀ 𝐤𝐡𝐨́𝐚 𝐭𝐡𝐢𝐬 𝐯𝐚̀ 𝐝𝐚̂́𝐮 𝐧𝐠𝐨𝐚̣̆𝐜 𝐯𝐮𝐨̂𝐧𝐠 [ ].

---oOo---

A keyword cannot be used as an identifier (name of the variable, class, interface, etc.). 
However, they can be used with the prefix '@'. For example, the class is a reserved keyword, so it cannot be used as an identifier, but @class can be used.
