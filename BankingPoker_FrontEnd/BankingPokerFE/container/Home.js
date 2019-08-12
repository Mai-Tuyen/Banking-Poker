import React, { Component } from "react";
import {
  StyleSheet,
  View,
  Text,
  TouchableOpacity,
  Alert,
  Button
} from "react-native";
import { Table, TableWrapper, Row, Cell } from "react-native-table-component";

class Home extends Component {
  constructor(props) {
    super(props);
    this.state = {
      tableHead: ["ID", "Player Name", "Buy in", "Detail"],
      tableData: [
        [1, "Tuyen", 1, "Detail"],
        [2, "Tuyen1", 2, "Detail"],
        [3, "Tuyen2", 4, "Detail"],
        [4, "Tuyen3", 0, "Detail"]
      ]
    };
  }

  render() {
    const state = this.state;
    const elementDetail = data => (
      <TouchableOpacity>
        <View style={styles.btn}>
          <Text style={styles.btnText}>Detail</Text>
        </View>
      </TouchableOpacity>
    );
    const elementSumAdd = data => (
      <View style={{ flex: 1, flexDirection: "row",justifyContent:"center" }}>
        <TouchableOpacity>
        <View style={styles.widthBtnSub}>
          <Text style={styles.btnText}>-</Text>
        </View>
      </TouchableOpacity>
        <Text style={{ marginLeft: 5, marginRight: 5 }}>{data}</Text>
        <TouchableOpacity>
        <View style={styles.widthBtnAdd}>
          <Text style={styles.btnText}>+</Text>
        </View>
      </TouchableOpacity>
      </View>
    );

    return (
      <View style={styles.container}>
        <Table borderStyle={{ borderColor: "transparent" }}>
          <Row
            data={state.tableHead}
            style={styles.head}
            textStyle={styles.text}
          />
          {state.tableData.map((rowData, index) => (
            <TableWrapper key={index} style={styles.row}>
              {rowData.map((cellData, cellIndex) => (
                <Cell
                  key={cellIndex}
                  data={
                    cellIndex === 3
                      ? elementDetail(cellData)
                      : cellIndex === 2
                      ? elementSumAdd(cellData)
                      : cellData
                  }
                  //   data={this.getCellData(cellIndex,cellData)}
                  textStyle={styles.text}
                />
              ))}
            </TableWrapper>
          ))}
        </Table>
      </View>
    );
  }
}
const styles = StyleSheet.create({
  container: { flex: 1, padding: 0, paddingTop: 30, backgroundColor: "#fff" },
  head: { height: 40, backgroundColor: "#808B97" },
  text: { margin: 6 },
  row: { flexDirection: "row", backgroundColor: "#FFF1C1" },
  btn: { width: 58, height: 18, backgroundColor: "#78B7BB", borderRadius: 2 },
  btnText: { textAlign: "center", color: "#fff" },
  widthBtnAdd: { width: 20,height:20, backgroundColor:"green", borderRadius: 2},
  widthBtnSub: { width: 20,height:20, backgroundColor:"red", borderRadius: 2},

});
export default Home;
